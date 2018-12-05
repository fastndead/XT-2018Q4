using System;
using System.Collections.Generic;

namespace TASK3.VectorGraphicsEditor
{
    public class Rectangle : IGraphicsEditor
    {
        private KeyValuePair<int, int> Corner;
        private KeyValuePair<int, int> Corner1;
        private KeyValuePair<int, int> Corner2;
        private KeyValuePair<int, int> Corner3;

        public Rectangle(KeyValuePair<int, int> corner, KeyValuePair<int, int> corner1, KeyValuePair<int, int> corner3, KeyValuePair<int, int> corner2)
        {
            Corner = corner;
            Corner1 = corner1;
            Corner3 = corner3;
            Corner2 = corner2;
        }


        public void Draw()
        {
            Console.WriteLine("RECTANGLE:");
            Console.WriteLine("Coordinates of corners: ({0},{1}), ({2},{3}), ({4},{5}), ({6},{7})", Corner.Key,
                Corner.Value, Corner1.Key, Corner1.Value, Corner2.Key, Corner2.Value, Corner3.Key, Corner3.Value);
            
            Console.WriteLine("________________________________________________");

        }
    }
}