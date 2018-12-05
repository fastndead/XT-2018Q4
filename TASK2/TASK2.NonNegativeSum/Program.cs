using System;

namespace TASK2.NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int len = r.Next(10);
            int[,,] arr = new int[len,len,len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        arr[i, j, k] = r.Next(-10,10);
                    }
                }
            }

            Console.WriteLine("Initial Array: ");
            foreach (var num in arr)
            {
                Console.Write(num + ", ");
            }

            int result = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            result = arr[i, j, k] + result;
                        }
                    }
                }
            }

            
            Console.WriteLine("\n Non-negative sum: " + result);
        }
    }
}