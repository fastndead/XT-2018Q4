using System;

namespace TASK3.VectorGraphicsEditor
{
    public class Circle : TASK3.Round.Round
    {
        public Circle(int r, int x, int y)
            : base(r, x, y)
        {}

        public void Draw()
        {
            Console.WriteLine("FILLED CIRCLE:");
            Show();
            Console.WriteLine("________________________________________________");
        }
    }
}