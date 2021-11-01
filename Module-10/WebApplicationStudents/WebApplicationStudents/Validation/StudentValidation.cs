using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            RuleFor(x => x.Telephone).NotEmpty().NotNull().MaximumLength(40).Must(HasValidTelephone);
            RuleFor(x => x.Score).InclusiveBetween(0, 1000);
        }

        private bool HasValidTelephone(string telephone)
        {
            Regex regex =
                new Regex(@"((\+7 )(\(\d{2,3}\) )(\d{3}-\d{2}-\d{2})) | (\+\d{3} \(\d{2}\) \d{3}-\d{4}) | (\d{1} \d{3} \d{3}-\d{2}-\d{2})");

            return regex.IsMatch(telephone);            
        }
    }
}
