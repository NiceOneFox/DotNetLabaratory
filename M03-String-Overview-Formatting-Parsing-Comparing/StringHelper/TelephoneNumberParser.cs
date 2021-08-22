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
       
        public void ParseTelephoneNumber()
        {
            string result = "";
            string text = myReader.Read();

            // parse

            myWriter.Write(result);
        }

        
    }
}
