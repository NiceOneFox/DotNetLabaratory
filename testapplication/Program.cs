using ArrayHelper;
using System;

namespace testapplication
{

    class Program
    {
        public static void PrintArrayConsole<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = {2, 5, 4, 9, 2, 0, 8, 9, 3, 4, 7, 6};
            string[] array2 = { "abd", "abc", "zdf", "zxc", "kls" };

            BubbleSort.BubbleSortAscending(array);
            BubbleSort.BubbleSortDescending(array2);

            PrintArrayConsole(array);
            Console.WriteLine();
            PrintArrayConsole(array2);
        }
    }
}
