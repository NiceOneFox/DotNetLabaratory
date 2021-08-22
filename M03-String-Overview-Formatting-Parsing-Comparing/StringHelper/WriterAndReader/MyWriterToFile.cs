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
        public void Write(string text)
        {          
             File.WriteAllText(filePath, text);
        }
    }
}
