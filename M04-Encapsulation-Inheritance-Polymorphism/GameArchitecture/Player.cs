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

        public bool isAlive { get; set; } = true;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            TotalScore = 0;
            isAlive = true;
        }

        public void Move()
        {
            throw new NotImplementedException();
            // from current position go to x, y coordinates
        }

        public void TakeBonuse(IBonus bonus)
        {
            throw new NotImplementedException();
        }
    }
}
