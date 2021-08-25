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

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Pair<int, int> GetPosition()
        {
            return new Pair<int, int>(X, Y);
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
