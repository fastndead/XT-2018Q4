using System;
using System.Threading;
using System.Threading.Tasks;

namespace TASK5.SortingUnit
{
    public class SortingUnit
    {
        private static event Action<int[]> SortStopped;

        public static async Task SortStart<T>(int[] arr, Func<int, int, bool> compare, Action<int[]> isStopped)
        {
            SortStopped += isStopped;
            await Task.Run(() => Sort<int>(ref arr, compare));
            SortStopped?.Invoke(arr);
        }

        public static bool Compare(int num1, int num2)
        {
            return num1 > num2;
        }

        public static bool Compare(string num1, string num2)
        {
            return num1.Length > num2.Length;
        }

        public static void Sort<T>(ref T[] array, Func<T, T, bool> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T cur = array[i];
                int j = i;
                while (j > 0 && comparer.Invoke(array[j - 1], cur))
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = cur;
            }
        }
    }

}