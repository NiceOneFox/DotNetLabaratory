using ArrayHelper;
using RectangleHelper;
using System;

namespace testapplication
{

    class Program
    {
        public static void PrintArrayConsole<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = {2, 5, 4, 9, 2, 0, 8, 9, 3, 4, 7, 6};
            string[] array2 = { "abd", "abc", "zdf", "zxc", "kls" };

            BubbleSort.BubbleSortAscending(array, true);
            BubbleSort.BubbleSortAscending(array2, false);

            PrintArrayConsole(array);        
            PrintArrayConsole(array2);

            /////////////////////////////////
            try {
                int width = 2;
                int height = 4;
                double[,] array3 = { {1, 4, -3, 0},
                                     {-9, 5, 2, 1} };

                double result = TwoDimensionalArray.SumOfPositiveElelements(array3, width, height);

                Console.WriteLine("sum of all positive elements: " + result);
                /////////////////////////////////
                double a = 4.3;
                double b = 6.87;

                double perimeter = Rectangle.Perimeter(a, b);
                Console.WriteLine($"Perimeter of rectangle with sides {a} and {b} equal {perimeter}");

                a = 120;
                b = 340;
                double square = Rectangle.Square(a, b);
                Console.WriteLine($"Squage of rectangle with sides {a} and {b} equal {square}");

                a = -3;
                b = 4;
                perimeter = Rectangle.Perimeter(a, b);
                Console.WriteLine($"Perimeter of rectangle with sides {a} and {b} equal {perimeter}");


            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }
        }
    }
}
