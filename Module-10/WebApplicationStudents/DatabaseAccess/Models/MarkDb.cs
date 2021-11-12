using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public record MarkDb
    {
        public int Id { get; set; }

        public int Assesment { get; set; }

        public string? Text { get; set; }


        public int LectureId { get; set; }
        
        public int StudentId { get; set; }

        public LectureDb Lecture { get; set; }

        public StudentDb Student { get; set; }
    }
}
