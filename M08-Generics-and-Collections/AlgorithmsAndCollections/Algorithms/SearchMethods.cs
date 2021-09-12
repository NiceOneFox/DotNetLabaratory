using System;
using System.Collections.Generic;

namespace AlgorithmsAndCollections
{
    public class SearchMethods
    {
        public static int BinarySerach<T>(List<T> collection, int low, int high, T target) where T : IComparable<T>
        {
            //границы сошлись
            if (low > high)
            {
                //элемент не найден
                return -1;
            }

            //средний индекс подмассива
            var middle = low + ((high - low) >> 1);
            //значение в средине подмассива
            T middleValue = collection[middle];

            if (middleValue.CompareTo(target) == 0)
            {
                return middle;
            }
            else
            {
                if (middleValue.CompareTo(target) > 0)
                {
                    //рекурсивный вызов поиска для левого подмассива
                    return BinarySerach<T>(collection, low, middle - 1, target);
                }
                else
                {
                    //рекурсивный вызов поиска для правого подмассива
                    return BinarySerach<T>(collection, middle + 1, high, target);
                }
            }
        }
    }
}
