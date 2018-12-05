using System;

namespace TASK3.VectorGraphicsEditor
{
    public class Ring: TASK3.Ring.Ring, IGraphicsEditor
    {
        private Ring MainRing;

        public Ring(int radius, int x, int y, int innerRadius) : base(radius, x, y, innerRadius)
        {}

        public void Draw()
        {
            Console.WriteLine("RING");
            Show();
            Console.WriteLine("________________________________________________");

        }
    }
}