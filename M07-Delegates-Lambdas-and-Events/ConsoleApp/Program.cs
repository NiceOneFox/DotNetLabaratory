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
            #region MatrixDelegates
            Func<List<int>, int> sumSortType = (List<int> x) => x.Sum();

            Func<List<int>, int> maxElementSortType = (List<int> x) => x.Max();

            Func<List<int>, int> minElementSortType = (List<int> x) => x.Min();

    
            Func<int, int, bool> ascOrderType = (int x, int y) => x >= y;

            Func<int, int, bool> descOrderType = (int x, int y) => y >= x;

            #endregion

            #region MatrixInitAndCallBubbleSort
            const int size = 5;

            List<List<int>> matrix = new List<List<int>>() {
                new List<int>() {1, 1, 0, 3, 2 },
                new List<int>() {3, 4, 5, 6, 7 },
                new List<int>() {2, 3, 4, 5, 6 },
                new List<int>() {8, 9, 0, 1, 2 },
                new List<int>() {5, 4, 3, 2, 1 } };

            matrix = MatrixSort.MatrixHelper.BubbleSort(matrix, size, ascOrderType, maxElementSortType);
           
            PrintMatrix(matrix, size);

            #endregion

            #region PublisherAndSubcribers
            Publisher publisher = new Publisher();
            var sub1 = new Subscriber();
            sub1.Subscribe(publisher);

            var sub2 = new Subscriber();
            sub2.Subscribe(publisher);

            publisher.Work();
            #endregion
        }
    }
}
