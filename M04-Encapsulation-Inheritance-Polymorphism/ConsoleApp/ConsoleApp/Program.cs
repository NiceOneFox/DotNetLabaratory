using GameArchitecture;
using GameArchitecture.Bonuses;
using GameArchitecture.Obstacles;
using GeometricShapes;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square area and perimeter");
            Square square = new Square(5.43);
            Console.WriteLine(square.GetArea());
            Console.WriteLine(square.GetPerimeter());

            Console.WriteLine("Rectangle area and perimeter");
            Rectangle rectangle = new Rectangle(3.2, 4.4);
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(rectangle.GetPerimeter());

            Console.WriteLine("Triangle area and perimeter");
            Triangle triangle = new Triangle(8.2, 7.3, 9.2);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.GetPerimeter());

            Console.WriteLine("Circle area and perimeter");
            Circle circle = new Circle(7.32);
            Console.WriteLine(circle.GetPerimeter());
            Console.WriteLine(circle.GetArea());

            Apple apple = new Apple(5, 4, 30);
            Cherry cherry = new Cherry(7, 90, 20);
            Bear bear = new Bear(16, 20);
            Wolf wolf = new Wolf(25, 30);
            Player player = new Player(5, 10);
            Tree tree = new Tree(3, 4);
            Stone stone = new Stone(8, 35);

            GameBoard gameBoard = new GameBoard(40, 40);

            List<IGameObject> gameObjects = new List<IGameObject>() {player, apple, cherry, bear, wolf, tree, stone};

            gameBoard.CreateBoard(gameObjects);

            while (gameBoard.isGameOver())
            {
                gameBoard.Play(); // make 1 iteration on game time
            }

            if (player.isAlive)
            {
                Console.WriteLine("Win");
            }
            else
            {
                Console.WriteLine("Lose");
            }

            
        }
    }
}
