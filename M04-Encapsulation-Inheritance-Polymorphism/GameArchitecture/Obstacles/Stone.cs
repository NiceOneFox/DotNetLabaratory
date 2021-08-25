using GameArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture.Obstacles
{
    public class Stone : IGameObject, IObstacles
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Stone(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
