using System;
using System.Collections.Generic;

namespace TASK3.Game
{
    public class Bonus : GameObject
    {
        private string Type
        {
            get { return Type; }
            set { Type = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        private KeyValuePair<int, int> Position
        {
            get { return Position; }
            set { Position = value; }
        }

        public Bonus(KeyValuePair<int, int> position, string type)
        {
            Position = position;
            Type = type;
        }
    }
}