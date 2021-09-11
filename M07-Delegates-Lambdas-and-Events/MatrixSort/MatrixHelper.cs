using System;

namespace MatrixSort
{
    public static class MatrixHelper
    {
        public delegate bool SortOrder(int x, int y);

        public delegate int SortType(int[] x);

        public static int[,] BubbleSort(int[,] matrix, int width, int height, SortOrder sortOrder, SortType sortType)
        {
            
            for (int i = 0; i < width; i++)
            {
                // get row 
                int[] row = new int[height];
                for (int k = 0; k < height; k++)
                {
                    row[k] = matrix[width, k];
                }
                Span<int> row2 = matrix[width, 0].Slice(0, 4);
                // get sortType result
                int result = sortType(row);

                // if result > current result => swap rows
                // deletegate SordOrder its about >, <, == 

                for (int j = 0; j < height; j++)
                {
                    // 1 сумма элементов в стркке матрице
                }
            }

            return matrix;
        }

    }
}
