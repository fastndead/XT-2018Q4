using System;

namespace TASK2.AnotherTriangle
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
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("*");   
                    }
                    else
                    {
                        Console.Write("**");
                    }

                }
                Console.WriteLine();
            }
        
        }
    }
}