using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationStudents.Models
{
    public record Mark(int Assesment, string Text, int StudentId, int LectureId);
}
