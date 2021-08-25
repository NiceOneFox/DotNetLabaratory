using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture.Bonuses
{
    public class Cherry : IGameObject, IBonus
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get; set; }

        public Cherry(int x, int y, int score)
        {
            X = x;
            Y = y;
            Score = score;
        }

    }
}
