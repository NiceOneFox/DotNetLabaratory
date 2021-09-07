using System.Collections.Generic;

namespace GameArchitecture
{
    public interface IGameBoard
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void CreateBoard(List<IGameObject> gameObjects);
        public void Play();
    }
}
