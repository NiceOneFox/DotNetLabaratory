using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationStudents.Models
{
    public record Student(string Name, int Age, string Email);
}
