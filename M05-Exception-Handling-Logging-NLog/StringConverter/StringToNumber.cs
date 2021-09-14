using Microsoft.Extensions.Logging;
using System;

namespace StringConverter
{
    public class StringToNumber
    {
        private readonly ILogger<StringToNumber> _logger;

        public StringToNumber(ILogger<StringToNumber> logger)
        {
            _logger = logger;
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
                }

                for (int i = str.Length - 1; i >= (0 + Convert.ToInt32(isNegative)); i--)
                {
                    if (!(str[i] >= '0' && str[i] <= '9')) // check if not a digit
                    {
                        _logger.LogError("number {str} contained not digit - {str[i]}", str, str[i]);
                        throw new ArgumentException($"number {str} contained not digit - {str[i]}");
                    }

                    result += (str[i] - '0') * (int)Math.Pow(10, str.Length - i - 1);
                }

                if (isNegative)
                {
                    result *= -1;
                    _logger.LogInformation("{str} is negative number", str);
                }

                _logger.LogInformation("{result} return value", result);
                return result;
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;            
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}
