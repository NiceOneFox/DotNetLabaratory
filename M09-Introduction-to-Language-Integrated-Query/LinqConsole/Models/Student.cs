using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole.Models
{
    public class Student
    {
        public string Name { get; set;  }

        public string TestName { get; set; }

        public DateTime Date { get; set; }

        public int Assesment { get; set; }

        public Student(string name, string testName, DateTime date, int assesment)
        {
            this.Name = name;
            this.TestName = testName;
            this.Date = date;
            this.Assesment = assesment;
        }
    }
}
