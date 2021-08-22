using StringHelper;
using StringHelper.WriterAndReader;
using System;
using System.IO;

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

            // Bridge Pattern
            IMyWriter myWriterToFile = 
                new MyWriterToFile(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M03-String-Overview-Formatting-Parsing-Comparing\outputFile.txt");

            IMyReader myReaderToFile = 
                new MyReaderFromFile(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M03-String-Overview-Formatting-Parsing-Comparing\inputFile.txt");

            var telephoneNumberParser = new TelephoneNumberParser(myWriterToFile, myReaderToFile);

            telephoneNumberParser.ParseTelephoneNumber();

        }
    }
}
