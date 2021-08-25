using System.Collections.Generic;

namespace GameArchitecture
{
    public class GameBoard : IGameBoard
    {
        public readonly int Width;

        public readonly int Height;

        public List<IGameObject> boardObjects { get; set; }

        public GameBoard(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Check if still bonuses on board
        /// </summary>
        /// <returns>true is bonuses on board</returns>
        public bool isGameOver()
        {
            foreach(var gameObj in boardObjects)
            {
                if (gameObj is IBonus)
                {
                    return true;
                }
            }
            return false;
        }

        public void CreateBoard(List<IGameObject> gameObjects)
        {
            // initialize all objects on board
            // key x,y - value object
            boardObjects = gameObjects;

        }
        public void AddObjectOnBoard(IGameObject gameObject)
        {
            boardObjects.Add(gameObject);
        }

        /// <summary>
        /// Game logic
        /// </summary>
        public void Play()
        {
            foreach(var gameObj in boardObjects)
            {
                if (gameObj is IPlayer)
                {
                    ((Player)gameObj).Move();
                    continue;
                }
                if (gameObj is Wolf)
                {
                    ((Wolf)gameObj).Hunt();
                }
                if (gameObj is Bear)
                {
                    ((Bear)gameObj).Hunt();
                }

            }
        }
    }
}