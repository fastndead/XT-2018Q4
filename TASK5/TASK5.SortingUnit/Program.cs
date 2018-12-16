using System;
using System.Threading;
using System.Threading.Tasks;

namespace TASK5.SortingUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1, 26, -12, 55, 34567, -234, 0};
            

            Console.WriteLine("Before sorting: ");
            foreach (var number in array)
            {
                Console.Write("{0} ", number);
            }


            Action<int[]> isDone = (x) =>
            {
                Console.WriteLine("\nSorting is done");
                foreach (var num in x)
                {
                    Console.Write("{0} ",num);
                }
            };
            
            var compare = new Func<int, int, bool>(SortingUnit.Compare);
            var thread = SortingUnit.SortStart<int>(array, compare, isDone);

            thread.Wait();




        }


    }
}