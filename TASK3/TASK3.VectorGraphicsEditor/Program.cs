using System;
using System.Collections.Generic;

namespace TASK3.VectorGraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraphicsEditor[] gr =
            {
                new Line(new KeyValuePair<int, int>(0, 0), new KeyValuePair<int, int>(1, 1)),
                new Rectangle(new KeyValuePair<int, int>(0, 0), new KeyValuePair<int, int>(1, 1),
                    new KeyValuePair<int, int>(1, 0), new KeyValuePair<int, int>(0, 1)),
                new Ring(1, 1, 1, 1),
                new Round(1, 1, 1),
            };
            foreach (var figure in gr)
            {
                figure.Draw();
            }
        }
    }
}