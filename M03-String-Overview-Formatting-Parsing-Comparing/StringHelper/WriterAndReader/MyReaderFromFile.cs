using System.IO;

namespace StringHelper.WriterAndReader
{
    public class MyReaderFromFile : IMyReader
    {
        private readonly string filePath;

        public MyReaderFromFile(string filePath)
        {
            this.filePath = filePath;
        }
        public string Read()
        {
            return File.ReadAllText(filePath);
        }
    }
}
