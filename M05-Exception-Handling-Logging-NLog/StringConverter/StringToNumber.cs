using Microsoft.Extensions.Logging;
using System;

namespace StringConverter
{
    public class StringToNumber
    {
        private readonly ILogger<StringToNumber> logger;

        public StringToNumber(ILogger<StringToNumber> logger)
        {
            this.logger = logger;
        }
        
        public int ConvertToInt(string str)
        {
            try
            {



                int result = 0; // 459
                bool isNegative = false;

                if (str[0] == '-')
                {
                    isNegative = true;
                    logger.LogInformation($"{str} is negative number");
                }

                for (int i = str.Length - 1; i >= (0 + Convert.ToInt32(isNegative)); i--)
                {
                    result += (str[i] - '0') * (int)Math.Pow(10, str.Length - i - 1);
                }

                if (isNegative)
                {
                    result *= -1;
                }

                return result;
            } catch (ArgumentNullException ex)
            {
                logger.LogDebug(ex.Message);
                throw new ArgumentNullException("str is null", ex);
            }
        }
    }
}
