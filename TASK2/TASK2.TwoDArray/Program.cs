using System;

namespace TASK2.TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int len = r.Next(10);
            int[,] arr = new int[len, len];

            for (int j = 0; j < len; j++)
            {
                for (int k = 0; k < len; k++)
                {
                    arr[j, k] = r.Next(-10,10);
                }
            }

            int result = 0;
            for (int j = 0; j < len; j++)
            {
                for (int k = 0; k < len; k++)
                {
                    if ((k + j) % 2 == 0)
                    {
                        result += arr[j, k];
                    }
                }
            }

            Console.WriteLine("Result: " + result);
        }
    }
}