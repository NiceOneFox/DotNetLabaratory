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
                if (str is null)
                {
                    throw new ArgumentNullException("String number was null");
                }
                
               
                int result = 0;
                bool isNegative = false;

                if (str[0] == '-')
                {
                    isNegative = true;
                    logger.LogInformation("{str} is negative number", str);
                }

                for (int i = str.Length - 1; i >= (0 + Convert.ToInt32(isNegative)); i--)
                {
                    if (!(str[i] >= '0' && str[i] <= '9')) // check if not a digit
                    {
                        logger.LogDebug("number {str} contained not digit - {str[i]}", str, str[i]);
                        throw new ArgumentException($"number {str} contained not digit - {str[i]}");
                    }
                    result += (str[i] - '0') * (int)Math.Pow(10, str.Length - i - 1);
                }

                if (isNegative)
                {
                    result *= -1;
                }

                logger.LogInformation("{result} return value", result);
                return result;
            } 
            catch (ArgumentNullException ex)
            {
                logger.LogError(ex, ex.Message);
                throw new ArgumentNullException(ex.Message, ex);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                logger.LogDebug(ex, ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
