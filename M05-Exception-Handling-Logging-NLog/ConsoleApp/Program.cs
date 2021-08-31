using System;

using StringConverter;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "-459";

            StringToNumber stringConverter = new StringToNumber(logger);
            Console.WriteLine(stringConverter.ConvertToInt(number));
        }
    }
}
