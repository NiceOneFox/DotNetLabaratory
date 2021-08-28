﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace GameArchitecture
{
    public class GameBoard : IGameBoard
    {
        private int width;

        private int height;

        public List<IGameObject> boardObjects { get; set; }

        public int Width { get => width; set { height = value; }
        }
        public int Height { get => height; set { height = value; } }

        public IGameObject this[int index]{ 
            get => boardObjects.ElementAt(index);
        }

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
            foreach (var gameObj in boardObjects)
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

            foreach (var gameObj in gameObjects)
            {
                if (gameObj.X > Width || gameObj.X < 0)
                {
                    throw new ArgumentException($"{gameObj} width out of range of board");
                }
                if (gameObj.Y > Height || gameObj.Y < 0)
                {
                    throw new ArgumentException($"{gameObj} height out of range of board");
                }
            }
            boardObjects = gameObjects;

        }

        /// <summary>
        /// Game logic
        /// </summary>
        public void Play()
        {
            foreach (var gameObj in boardObjects)
            {
                if (gameObj is Wolf w)
                {
                    w.Hunt(); // ((Wolf)gameObj).Hunt();                  
                }
                if (gameObj is Bear b)
                {
                    b.Hunt();
                }
            }
        }

    }
}