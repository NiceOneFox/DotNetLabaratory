using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture.Bonuses
{
    class Cherry : IGameObject, IBonus
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Pair<int, int> GetPosition()
        {
            throw new NotImplementedException();
        }

        public int GetScore()
        {
            throw new NotImplementedException();
        }
    }
}
