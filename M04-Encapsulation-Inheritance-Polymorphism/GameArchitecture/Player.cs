using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public class Player : IPlayer, ICreature
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int TotalScore { get; private set; }

        public bool IsAlive { get; set; } = true;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            TotalScore = 0;
            IsAlive = true;
        }

        public void TakeBonus(IBonus bonus)
        {
            TotalScore += bonus.Score;
        }

        public void Move(IGameBoard gameBoard)
        {
            // move to somewhere
            // if IObstacle go another way
            // if IMonster x, y  = X, Y -- Dead
            // if IBonus TakeBonus() method
            return;
        }
    }
}
