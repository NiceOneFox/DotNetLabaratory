using System;

namespace ArrayHelper
{
    public static class BubbleSort
    {
        public static void BubbleSortAscending<T>(T[] array) where T : IComparable<T>
        {
            T temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i].CompareTo(array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }
            
        }

        public static void BubbleSortDescending<T>(T[] array) where T : IComparable<T>
        {
            T temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) < 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
    }
}
