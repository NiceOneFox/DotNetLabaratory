using GameArchitecture.Interfaces;

namespace GameArchitecture.Obstacles
{
    public class Tree : IGameObject, IObstacles
    {
        public Tree(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
