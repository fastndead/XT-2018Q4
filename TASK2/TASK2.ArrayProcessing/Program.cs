using System;

namespace TASK2.ArrayProcessing
{
    class Program
    {
        static void Show(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }

        static int FindMinMax(int[] arr, bool findMin)
        {
            if (findMin)
            {
                int min = arr[0];
                foreach (var item in arr)
                {
                    if(item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }
            else
            {
                int max = arr[0];
                foreach (var item in arr)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int len = r.Next(10, 30);
            int[] arr = new int[len];
            for (int i = 0; i <  len; i++)
            {
                arr[i] = r.Next(100);
            }

            Console.Write("Initial array: ");
            Show(arr);

            Console.WriteLine("Max element: " + FindMinMax(arr, false));
            Console.WriteLine("Min element: " + FindMinMax(arr, true));

            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int temp;
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
            Console.Write("Sorted array: ");
            Show(arr);

        }
    }
}