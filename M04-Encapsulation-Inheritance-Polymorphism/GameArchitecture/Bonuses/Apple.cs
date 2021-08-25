using System;

namespace GameArchitecture.Bonuses
{
    public class Apple : IGameObject, IBonus
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get ; set; }

        public Apple(int x, int y, int score)
        {
            X = x;
            Y = y;
            Score = score;  
        }

        public int GetScore() { return Score; }
    }
}
