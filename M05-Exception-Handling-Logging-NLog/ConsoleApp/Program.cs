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
            string number = "-45d80";

            NLog.Logger logger = NLog.LogManager.GetLogger(typeof(StringToNumber).FullName);

            try
            {
                var config = new ConfigurationBuilder()
               .Build();

                var servicesProvider = BuildDIContainer(config);

                using (servicesProvider as IDisposable)
                {
                    var converter = servicesProvider.GetRequiredService<StringToNumber>();

                    converter.ConvertToInt(number);

                }
            }
            catch (ArgumentNullException ex)
            {
                logger.Error(ex.Message, ex);
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, ex.Message);
                logger.Error(ex, ex.Message);
            }
        }
    }
}
