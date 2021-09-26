using LinqConsole.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LinqConsole.DataAdapter
{
    public class DataAdapter
    {
        private readonly string _filePath;

        public DataAdapter(string filePath)
        {
            _filePath = filePath;
        }
        public List<Student> RetrieveDataFromJSON()
        {
            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Student>>(jsonString);
        }
    }
}
