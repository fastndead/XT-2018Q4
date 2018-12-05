using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace TASK3.Round
{
    public class Round
    {
        private int Radius;
        private KeyValuePair<int, int> Position;
        protected double Circumference => 2 * Math.PI * this.Radius;
        protected double Area => Math.PI * this.Radius * this.Radius;

        public Round()
            :this(1,0,0)
        {
        }

        public Round(int r, int x, int y)
        {
            if (r <= 0)
            {
                throw new Exception("Incorrect radius value");
            }
            this.Radius = r;
            this.Position = new KeyValuePair<int, int>(x, y);
        }

        public virtual void Show()
        {
            Console.WriteLine("Radius: {0}", this.Radius);
            Console.WriteLine("Coordinates: x = {0}, y = {1}", this.Position.Key, this.Position.Value);
            Console.WriteLine("Circumference: {0}", this.Circumference);
            Console.WriteLine("Area: {0}", this.Area);
        }



    }
}