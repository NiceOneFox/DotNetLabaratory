using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole.Models
{
    public class Student : IComparable<Student>, IEquatable<Student>
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

        public int CompareTo(Student other)
        {
            if (other is null) return 1;

            if (this.Name == other.Name && 
                this.TestName == other.TestName &&
                this.Date == other.Date &&
                this.Assesment == other.Assesment)
            {
                return 0;
            }

            return -1;
        }

        public bool Equals(Student other)
        {
            if (this.Name == other.Name &&
                this.TestName == other.TestName &&
                this.Date == other.Date &&
                this.Assesment == other.Assesment)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
