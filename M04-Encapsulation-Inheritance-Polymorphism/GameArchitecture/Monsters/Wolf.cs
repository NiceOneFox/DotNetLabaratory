using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public class Wolf : IGameObject, ICreature, IMonster
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Attack(ICreature creature)
        {
            throw new NotImplementedException();
        }


        public void Hunt()
        {
            throw new NotImplementedException();
        }

        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public Pair<int, int> GetPosition()
        {
            throw new NotImplementedException();
        }
    }
}
