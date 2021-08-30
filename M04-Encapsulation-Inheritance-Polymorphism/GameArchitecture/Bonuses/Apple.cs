using System;

namespace GameArchitecture.Bonuses
{
    public class Apple : IGameObject, IBonus
    {
        public int Score { get ; set; }

        public Apple(int x, int y, int score)
        {
            X = x;
            Y = y;
            Score = score;  
        }
    }
}
