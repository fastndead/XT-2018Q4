using System.Collections.Generic;

namespace TASK3.Game
{
    public class Player : IAction
    {
        public Player(KeyValuePair<int, int> position, Bonus[] bonusCollected)
        {
            Position = position;
            BonusCollected = bonusCollected;
        }

        private Bonus[] BonusCollected;

        private KeyValuePair<int, int> Position
        {
            get { return Position; }
            set { Position = value; }
        }

        public void Die()
        {}

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