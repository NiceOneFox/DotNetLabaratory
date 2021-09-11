using System;

namespace MatrixSort
{
    public static class MatrixHelper
    {
        public delegate bool SortOrder(int x);

        public delegate bool SortType(int x, int y);

        public static int[,] BubbleSort(int[,] matrix, int width, int height, SortOrder sortOrder, SortType sortType)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                }
            }
            return new int[3, 3];
        }

    }
}
