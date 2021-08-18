using System;

public static class TwoDimensionalArray
{
    public static double SumOfPositiveElelements(double[,] array, int width, int height) 
    {
        double sumOfElements = 0d;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (array[i, j] > 0)
                {
                   sumOfElements += array[i, j];
                }
            }
        }

        return sumOfElements;
    }
}
