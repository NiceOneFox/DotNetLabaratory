using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixSort
{
    public static class MatrixHelper
    {
        public static List<List<int>> BubbleSort(List<List<int>> matrix, int size, 
            Func<int, int, bool> sortOrder, Func<List<int>, int> sortType)
        {
            List<int> tempRow;

            for (int i = 0; i < size; i++)
            {
                // get row 
                List<int> row = matrix[i].ToList();

                for (int j = i + 1; j < size; j++)
                {
                    List<int> nextRow = matrix[j].ToList();

                    if (sortOrder(sortType(row), sortType(nextRow)))
                    {
                        // swap rows
                        tempRow = matrix[i].ToList();
                        matrix[i] = nextRow;
                        matrix[j] = tempRow;
                    }
                }
            }
            return matrix;
        }

    }
}
