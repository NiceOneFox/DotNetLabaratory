using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Validation
{
    public class StudentValidation : AbstractValidator<Student>
    {
        public StudentValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().Length(2, 30);
            RuleFor(x => x.LastName).NotEmpty().Length(2, 30);
            RuleFor(x => x.Age).NotEmpty().GreaterThan(0).LessThan(100);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Score).GreaterThan(0);
        }
    }
}
