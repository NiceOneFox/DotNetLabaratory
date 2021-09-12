using AlgorithmsAndCollections;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 4, 1, 5, 9, 3 };
            List<string> collection2 = new List<string>() { "hey", "hi", "hello", "Greetings" };

            collection.Sort(); // collections must be sorted
            collection2.Sort();

            var target = 3;
            var target2 = "hi";

            int result = SearchMethods.BinarySerach(collection, 0, collection.Count, target);
            int result2 = SearchMethods.BinarySerach(collection2, 0, collection2.Count, target2);

            Console.WriteLine($"Index of element {target} was: {result}");
            Console.WriteLine($"Index of element {target2} was: {result2}");
            ///////////////

            MathMethods mathMethods = new MathMethods();

            foreach (var number in mathMethods.Fibonacci())
            {
                Console.WriteLine(number);
            }
            /////////////
            ///
            Queue<int> q = new Queue<int>();
            q.Dequeue
        }
    }
}
