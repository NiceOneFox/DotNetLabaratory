using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public record AttendanceBl(int StudentId, int LectureId, bool isAttend);
}
