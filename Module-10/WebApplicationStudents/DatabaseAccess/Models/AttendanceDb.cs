using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public record AttendanceDb
    {
        public StudentDb Student { get; set; }

        public LectureDb Lecture { get; set; }


        public int StudentId { get; set; }

        public int LectureId { get; set; }


        public bool isAttend { get; set; }
    }
}
