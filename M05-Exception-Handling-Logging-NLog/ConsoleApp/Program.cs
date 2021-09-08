using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using StringConverter;

namespace ConsoleApp
{

    class Program
    {
        private static IServiceProvider BuildDIContainer(IConfiguration config)
        {
            return new ServiceCollection()
                  //Add DI Classes here
                  .AddTransient<StringToNumber>()
                  .AddLogging(loggingBuilder =>
                  {
                  // configure Logging with NLog
                  loggingBuilder.ClearProviders();
                      loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                      loggingBuilder.AddNLog(config);
                  })
                  .BuildServiceProvider();
        }

        static void Main(string[] args)
        {
            string number = "-459";
            // консоль меседжи от экспешионов

            //NLog.Logger logger = NLog.LogManager.GetLogger(typeof(StringToNumber).FullName);

            //logger.Info("test info");
            //logger.Trace("trace smth");
            //logger.Fatal("fatal error");


            var config = new ConfigurationBuilder()
           .Build();

            var servicesProvider = BuildDIContainer(config);

            using (servicesProvider as IDisposable)
            {
                var converter = servicesProvider.GetRequiredService<StringToNumber>();

                converter.ConvertToInt(number);

            }

           // var stringToNumberConverter = new StringToNumber(logger);
            //  Console.WriteLine(stringConverter.ConvertToInt(number));
        }
}
}
