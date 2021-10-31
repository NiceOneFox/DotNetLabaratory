using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationStudents.Models
{
    public record Attendance(int StudentId, int LectureId, bool isAttend);
}
