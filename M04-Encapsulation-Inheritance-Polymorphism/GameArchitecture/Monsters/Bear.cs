using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public class Bear : IGameObject, ICreature, IMonster
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Bear(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Attack(ICreature creature)
        {
            throw new NotImplementedException();
        }

        public void Hunt()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
