using System;

namespace TASK2.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 999; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine("Summary of Numbers, that are multiples of 3 and 5 and less, than 1000: " + result);
        }
    }
}