using System;

namespace TASK3.Ring
{
    public class Ring : Round.Round
    {
        private int InnerRadius;
        private double CircumferenceSum => this.Circumference + 2 * Math.PI * this.InnerRadius;

        private double InnerArea => this.Area - Math.PI * this.InnerRadius * this.InnerRadius;

        public Ring(int radius, int x, int y, int innerRadius)
            :base(radius,x,y)
        {
            if (innerRadius > radius || radius <= 0 || innerRadius <= 0)
            {
                throw new Exception("Incorrect radii values");
            }
            this.InnerRadius = innerRadius;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Inner Radius: {0}", this.InnerRadius);
            Console.WriteLine("Inner Area: {0}", this.InnerArea);
            Console.WriteLine("Sum of Circumferences: {0}", CircumferenceSum);
        }
    }
}