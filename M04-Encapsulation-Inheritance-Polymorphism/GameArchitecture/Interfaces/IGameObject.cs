using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameArchitecture
{
    public interface IGameObject
    {
        public int X { get; set; }

        public int Y { get; set; }
        public Pair<int, int> GetPosition() { return new Pair<int, int>(X, Y); }
    }
}
