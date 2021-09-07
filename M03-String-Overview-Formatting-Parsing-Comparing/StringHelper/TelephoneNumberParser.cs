using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace StringHelper
{
    public class TelephoneNumberParser
    {
        private readonly IMyWriter writer;

        private readonly IMyReader reader;

        public TelephoneNumberParser(IMyWriter writer, IMyReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        /// <summary>
        /// Get text from resource, parse all telephone numbers and Write somewhere
        /// </summary>
        public void ParseTelephoneNumber()
        {
            string text = reader.Read();

            Regex regex = 
                new Regex(@"((\+7 )(\(\d{2,3}\) )(\d{3}-\d{2}-\d{2})) | (\+\d{3} \(\d{2}\) \d{3}-\d{4}) | (\d{1} \d{3} \d{3}-\d{2}-\d{2})");

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(matches.Count);

            List<string> cellPhones = new List<string>(matches.Cast<Match>().Select(m => m.Value.Trim()).ToList());          

            writer.Write(cellPhones);
        }


    }
}
