using System.Collections.Generic;

namespace TASK3.Game
{
    public class Enemy : IAction
    {
        public Enemy(KeyValuePair<int, int> position)
        {
            Position = position;
        }

        
        private KeyValuePair<int, int> Position
        {
            get { return Position; }
            set { Position = value; }
        }
        
        public void MoveUp()
        {}

        public void MoveDown()
        {}

        public void MoveRight()
        {}

        public void MoveLeft()
        {}
    }
}