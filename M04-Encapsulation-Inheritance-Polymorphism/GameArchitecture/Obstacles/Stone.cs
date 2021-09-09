using GameArchitecture.Interfaces;

namespace GameArchitecture.Obstacles
{
    public class Stone : IGameObject, IObstacles
    {
        public Stone(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
