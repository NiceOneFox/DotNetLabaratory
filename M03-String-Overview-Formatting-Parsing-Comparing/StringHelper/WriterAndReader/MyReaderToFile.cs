using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper.WriterAndReader
{
    public class MyReaderToFile : IMyReader
    {
        private readonly string filePath;

        public MyReaderToFile(string path)
        {
            filePath = path;
        }
        public string Read()
        {
            throw new NotImplementedException();
        }
    }
}
