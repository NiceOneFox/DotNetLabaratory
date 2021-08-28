using System;
using System.Collections.Generic;
using System.Text;

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

            // parse
            bool isNumberStarted = false;

            bool isNumberEnd = false;

            List<string> cellPhones = new List<string>();

            StringBuilder phone = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]) || text[i] == '+' || text[i] == '-' || text[i] == '(' || text[i] == ')' || Char.IsWhiteSpace(text[i]))
                {
                    if (Char.IsWhiteSpace(text[i]) && !isNumberStarted)
                    {
                        continue;
                    }
                    phone.Append(text[i]);
                    isNumberStarted = true;
                 
                    continue;
                }
                else
                {
                    isNumberEnd = true;
                }
               
                if (isNumberStarted && isNumberEnd) // add full telephone number to list
                {
                    cellPhones.Add(phone.ToString());
                    phone.Clear();

                    isNumberEnd = false;
                    isNumberStarted = false;
                }
           
            }

            writer.Write(cellPhones);
        }


    }
}
