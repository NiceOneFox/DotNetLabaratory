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

        public Tuple<int, int> GetPosition() { return new Tuple<int, int>(X, Y); }
    }
}
