using System;

namespace ArrayHelper
{
    public static class BubbleSort
    {
        /// <summary>
        /// Bubble sort of array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="order">Flag to choose in which order to sort array (ASC/DESC)</param>
        public static void Sort<T>(T[] array, bool order) where T : IComparable<T>
        {
            T temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0 && order) //ascending order if order true
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    } else if (array[i].CompareTo(array[j]) < 0 && !order)  //descending order if order false
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
