using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public class Player : IGameObject, IPlayer, ICreature
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int TotalScore { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            TotalScore = 0;
        }

        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void TakeBonuse(IBonus bonus)
        {
            throw new NotImplementedException();
        }
    }
}
