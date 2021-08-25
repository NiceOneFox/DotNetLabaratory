using GameArchitecture;
using GameArchitecture.Bonuses;
using GeometricShapes;
using System;

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
            Console.WriteLine(apple.GetScore());
            
        }
    }
}
