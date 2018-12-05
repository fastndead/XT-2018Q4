using System;

namespace Epam.TASK1.Sequence
{
    class Program
    {
        public static void Sequence(int n)
        {
            for (int i = 1; i <= n; i++)
            {
Console.Write(i + " ");
            }
        }

        static void Main()
        {
            Sequence(int.Parse(Console.ReadLine()));
        }
    }
}