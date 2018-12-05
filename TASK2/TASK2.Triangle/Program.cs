using System;
using System.Runtime.InteropServices;

namespace TASK2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            try
            {
                Console.Write("Enter N: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                throw;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}