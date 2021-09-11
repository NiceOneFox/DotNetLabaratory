using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        public static void PrintMatrix(List<List<int>> matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            //////////
            Func<List<int>, int> SumSortType = (List<int> x) => x.Sum();

            Func<List<int>, int> MaxElementSortType = (List<int> x) => x.Max();

            Func<List<int>, int> MinElementSortType = (List<int> x) => x.Min();

            /////////
            Func<int, int, bool> AscOrderType = (int x, int y) => x >= y;

            Func<int, int, bool> DescOrderType = (int x, int y) => y >= x;

            ////////
            const int SIZE = 5;

            List<List<int>> matrix = new List<List<int>>() {
                new List<int>() {1, 1, 0, 3, 2 },
                new List<int>() {3, 4, 5, 6, 7 },
                new List<int>() {2, 3, 4, 5, 6 },
                new List<int>() {8, 9, 0, 1, 2 },
                new List<int>() {5, 4, 3, 2, 1 } };

            matrix = MatrixSort.MatrixHelper.BubbleSort(matrix, SIZE, AscOrderType, MaxElementSortType);

            PrintMatrix(matrix, SIZE);
            ///////////////////////////////
            Publisher publisher = new Publisher();
            var sub1 = new Subscriber();
            sub1.Subscribe(publisher);

            var sub2 = new Subscriber();
            sub2.Subscribe(publisher);

            publisher.Work();


        }
    }
}
