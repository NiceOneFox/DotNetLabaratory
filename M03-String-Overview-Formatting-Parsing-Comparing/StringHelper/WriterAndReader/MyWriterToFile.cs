using System.Collections.Generic;
using System.IO;


namespace StringHelper
{
    public class MyWriterToFile : IMyWriter
    {
        private readonly string filePath;

        public MyWriterToFile(string filePath)
        {
            this.filePath = filePath;
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
