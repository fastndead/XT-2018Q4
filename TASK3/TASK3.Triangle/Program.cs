using System;

namespace TASK3.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1,
                b = 2, 
                c = 3 ;
            Triangle triangle;
            try
            {
                triangle = new Triangle(a,b,c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            triangle.Show();
        }
    }
}