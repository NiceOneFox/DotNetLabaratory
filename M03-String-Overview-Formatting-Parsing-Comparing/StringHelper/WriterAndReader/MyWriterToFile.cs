using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper
{
    public class MyWriterToFile : IMyWriter
    {
        private readonly string filePath;

        public MyWriterToFile(string path)
        {
            filePath = path;
        }
        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
