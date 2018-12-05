using System;
using System.Reflection.Metadata;

namespace TASK3.Triangle
{
    public class Triangle
    {
        private int a;
        private int b;
        private int c;
        private double S;
        private double P;

        Triangle()
            :this(1,1,1)
        {
        }

        public Triangle(int a, int b, int c)
        {
            if (a + b < c || a + c < b || b + c < a || a * b * c <= 0)
            {
                throw new Exception("Wrong length of sides");
            }

            this.a = a;
            this.b = b;
            this.c = c;

            this.P = a + b + c;
            var p = this.P / 2; //half of the perimeter
            this.S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Show()
        {
            Console.WriteLine("Sides: a = {0}, b = {1}, c = {2}", this.a, this.b, this.c);
            Console.WriteLine("Area: {0}", this.S);
            Console.WriteLine("Perimeter: {0}", this.P);
        }

    }
}