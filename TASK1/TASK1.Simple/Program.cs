using System;

namespace Epam.TASK1.Simple
{
    class Program
    {
        public static bool Simple(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        static void Main(string[] args)
        {
            Console.Write(Simple(int.Parse(Console.ReadLine())).ToString());
            
        }
    }
}