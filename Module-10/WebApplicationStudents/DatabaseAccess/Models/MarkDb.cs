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

        public int Mark { get; set; }

        public string? Text { get; set; }


        public LectureDb Lecture { get; set; }

        public StudentDb Student { get; set; }
    }
}
