using System;

namespace TASK1.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            try
            {
                Console.Write("Enter a: ");
                a = int.Parse(Console.ReadLine());
                
                Console.Write("Enter b: ");
                b = int.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                throw;
            }

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("ERROR. Incorrect numbers.");
            }
            else
            {
                var s = a * b;
                Console.WriteLine("S = " + s);   
            }
        }
    }
}