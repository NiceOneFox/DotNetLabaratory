using System.Collections.Generic;
using System.IO;


namespace StringHelper
{
    public class MyWriterToFile : IMyWriter
    {
        private readonly string filePath;

        public MyWriterToFile(string path)
        {
            filePath = path;
        }
        public async void Write(IEnumerable<string> text)
        {
            using (StreamWriter file = new StreamWriter(filePath))
            {
                foreach (string line in text)
                {
                    await file.WriteLineAsync(line);
                }
            }
        }
    }
}
