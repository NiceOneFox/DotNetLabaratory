using System;

using StringConverter;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "-459";
            // консоль меседжи от экспешионов

            NLog.Logger logger = NLog.LogManager.GetLogger(typeof(StringToNumber).FullName);

            logger.Info("test info");
            logger.Trace("trace smth");
            logger.Fatal("fatal error");
           //StringToNumber stringConverter = new StringToNumber(logger);


          //  Console.WriteLine(stringConverter.ConvertToInt(number));
        }
    }
}
