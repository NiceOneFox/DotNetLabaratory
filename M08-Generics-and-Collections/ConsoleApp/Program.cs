using AlgorithmsAndCollections;
using AlgorithmsAndCollections.Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region CollectionBinarySearch
                List<int> collection = new List<int>() { 4, 1, 5, 9, 3 };
                List<string> collection2 = new List<string>() { "hey", "hi", "hello", "Greetings" };

                collection.Sort(); // collections must be sorted
                collection2.Sort();

                var target = 3;
                var target2 = "hi";

                int result =  SearchMethods.BinarySerach(collection, 0, collection.Count, target);
                int result2 = SearchMethods.BinarySerach(collection2, 0, collection2.Count, target2);

                Console.WriteLine($"Index of element {target} was: {result}");
                Console.WriteLine($"Index of element {target2} was: {result2}");

                #endregion CollectionBinarySearch

                #region RPN

                AlgorithmsAndCollections.Collections.Queue<int> queue = new AlgorithmsAndCollections.Collections.Queue<int>();
                queue.Enqueue(5);
                queue.Enqueue(7);
                queue.Enqueue(8);
                queue.Enqueue(2);

                Console.WriteLine(queue.Dequeue());

                foreach (int value in queue)
                {
                    Console.Write(value + " ");
                }
                ////////////////////

                Console.WriteLine("\nCalculator program");
                Console.WriteLine(RPN.Calculate("(5,4 + 4) * (3 / 5) - 40"));

                #endregion RPN

                #region MathMethods

                MathMethods mathMethods = new MathMethods();

                foreach (var number in mathMethods.Fibonacci())
                {
                    Console.WriteLine(number);
                }

                #endregion MathMethods
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
