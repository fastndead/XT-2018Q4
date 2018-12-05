using System;
using System.Collections.Generic;

namespace TASK3.VectorGraphicsEditor
{
    public class Line : IGraphicsEditor
    {
        private KeyValuePair<int, int> Start;
        private KeyValuePair<int, int> End;

        public Line(KeyValuePair<int, int> start, KeyValuePair<int, int> end)
        {
            this.Start = start;
            this.End = end;
        }

        public void Draw()
        {
            Console.WriteLine("LINE:");
            Console.WriteLine("Starts at: ({0},{1})", Start.Key, Start.Value);
            Console.WriteLine("Ends at: ({0},{1})", End.Key, End.Value);
            Console.WriteLine("________________________________________________");
        }
    }
}