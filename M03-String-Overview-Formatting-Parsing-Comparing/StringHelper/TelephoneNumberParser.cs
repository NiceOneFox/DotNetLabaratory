using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper
{
    public class TelephoneNumberParser
    {
        private readonly IMyWriter myWriter;

        private readonly IMyReader myReader;

        public TelephoneNumberParser(IMyWriter Writer, IMyReader Reader)
        {
            myWriter = Writer;
            myReader = Reader;
        }
       
        /// <summary>
        /// Get text from resource, parse all telephone numbers and Write somewhere
        /// </summary>
        public void ParseTelephoneNumber()
        {
            string result = "";
            string text = myReader.Read();

            // parse
            

            myWriter.Write(text);
        }

        
    }
}
