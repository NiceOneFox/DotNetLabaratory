using StringHelper;
using System;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordLength.AverageWordLength("Hello World, triple double once T-34"));

            Console.WriteLine(MultiplyCharater.DoubleCharacters("omg i love shrek", "o kek"));

            Console.WriteLine(SumOfStringNumbers.SumOfTwoLongNumbers("380", "50"));

            Console.WriteLine(WordReverse.Reverse("The greatest victory is that which requires no battle"));
        }
    }
}
