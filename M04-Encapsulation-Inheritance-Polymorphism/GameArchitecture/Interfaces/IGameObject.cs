using System;

namespace GameArchitecture
{
    public abstract class IGameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Tuple<int, int> GetPosition() { return new Tuple<int, int>(X, Y); }
    }
}
