using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Validation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(6, 100);
            RuleFor(x => x.Age).NotEmpty().GreaterThan(0).LessThan(100);
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
