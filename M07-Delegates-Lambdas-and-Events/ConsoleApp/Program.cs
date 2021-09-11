using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Func<int, int, bool> SortType = (int x, int y) =>
            {
                if (x >= y)
                {
                    return true;
                }
                else return false;
            };

            Func<int, int, bool> OrderType = (int x, int y) =>
            {
                if (x >= y)
                {
                    return true;
                }
                else return false;
            };

            const int WIDTH = 5;
            const int HEIGHT = 5;

            int[,] matrix = new int[WIDTH, HEIGHT] {
                {4, 2, 7, 5, 2 },
                {9, 0, 1, 3, 6 },
                {6, 3, 9, 4, 1 },
                {5, 1, 0, 3, 8 },
                {2, 4, 7, 2, 9 } };

            matrix = MatrixSort.MatrixHelper.BubbleSort(matrix, WIDTH, HEIGHT, SortType, OrderType);
        }
    }
}
