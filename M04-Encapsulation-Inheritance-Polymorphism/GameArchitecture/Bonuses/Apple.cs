using System;

namespace GameArchitecture.Bonuses
{
    class Apple : IGameObject, IBonus
    {
        private int score { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Apple(int score)
        {
            this.score = score;
        }
        public Pair<int, int> GetPosition()
        {
            throw new NotImplementedException();
        }

        public int GetScore()
        {
            return score;
        }
    }
}
