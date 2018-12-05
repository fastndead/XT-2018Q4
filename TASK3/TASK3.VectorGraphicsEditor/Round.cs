using System;

namespace TASK3.VectorGraphicsEditor
{
    public class Round: TASK3.Round.Round, IGraphicsEditor
    {
        private Round MainRound;

        public Round(int radius, int x, int y)
            :base(radius,x,y)
        {}

        public void Draw()
        {
            Console.WriteLine("UNFILLED CIRCLE:");
            Show();
            Console.WriteLine("________________________________________________");

        }
    }
}