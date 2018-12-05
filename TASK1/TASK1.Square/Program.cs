using System;

namespace Epam.Task1.Square
{
    class Program
    {
        public static void Square(int n)
        {
            for (int i = 0; i < n; i++)
            {
for (int j = 0; j < n; j++)
                {
                    if (i == n/2 && j == n/2)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Square(int.Parse(Console.ReadLine()));
        }
    }
}