using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public record LectureDb
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }


        public HomeworkDb Homework { get; set; }

        public LectorDb Lector { get; set; }

        public ICollection<StudentDb> Students { get; set; }

        public ICollection<AttendanceDb> Attendances { get; set; }
    }
}
