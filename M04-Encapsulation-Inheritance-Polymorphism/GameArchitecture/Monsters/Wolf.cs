using System;

namespace GameArchitecture
{
    public class Wolf : IGameObject, ICreature, IMonster
    {
        public Wolf(int x, int y)
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

    }
}
