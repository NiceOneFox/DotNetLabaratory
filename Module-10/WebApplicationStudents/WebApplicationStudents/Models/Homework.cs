using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationStudents.Models
{
    public record Homework(string Text, DateTime DeadLine, int LectureId);
}
