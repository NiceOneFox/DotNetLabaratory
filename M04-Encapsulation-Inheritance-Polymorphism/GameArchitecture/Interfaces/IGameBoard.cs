using System.Collections.Generic;

namespace GameArchitecture
{
    public interface IGameBoard
    {
        public void CreateBoard(List<IGameObject> gameObjects);

        public void Play();
    }
}
