using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public record HomeworkDb
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime DeadLine { get; set; }


        public LectureDb Lecture { get; set; }

        public int LectureId { get; set; }
    }
}
