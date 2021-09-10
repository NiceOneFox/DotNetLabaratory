using NUnit.Framework;
using StringConverter;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;

namespace StringConverterTests
{
    public class StringToNumberTests
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
        [TestCase("455", 455)]
        public void ConverToInt(string number, int expectedResult)
        {
            //Arrange
            NLog.Logger logger = NLog.LogManager.GetLogger(typeof(StringToNumber).FullName);

            int result = int.MaxValue;
            //StringToNumber stringToNumber = new StringToNumber(logger);
            var config = new ConfigurationBuilder()
               .Build();

            var servicesProvider = BuildDIContainer(config);

            using (servicesProvider as IDisposable)
            {
                var converter = servicesProvider.GetRequiredService<StringToNumber>();

                // act
                result = converter.ConvertToInt(number);
            }

            //assert 
            Assert.AreEqual(expectedResult, result);
        }
    }
}