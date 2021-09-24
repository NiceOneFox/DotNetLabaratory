using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParser
{
    public static class ConsoleParser
    {
        public static void SortByName<T>(IEnumerable<T> collection, string argument)
        {
         
        }

        // return true if option is set by user otherwise it return false;
        public static bool IsSetByUser<T>(this T options, string option)
        {
            //unparse options
            string args = CommandLine.Parser.Default.FormatCommandLine(options, config => config.SkipDefault = true);
            Console.WriteLine($"Unparser:  {args}");
            var status = args.Contains(option);
            if (status)
            {
                Console.WriteLine($"option: {option} is Set by user");
                return true;
            }
            Console.WriteLine("option: {option} is Set by Parser");
            return false;
        }
    }
}
