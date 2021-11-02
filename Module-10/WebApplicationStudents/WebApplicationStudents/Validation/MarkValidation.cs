using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Validation
{
    public class MarkValidation : AbstractValidator<Mark>
    {
        public MarkValidation()
        {
            RuleFor(x => x.Assesment).NotEmpty().NotNull().InclusiveBetween(1, 5).
                WithMessage("Assesment value must be between 1 and 5");
            RuleFor(x => x.Text).MaximumLength(255);
            RuleFor(x => x.StudentId).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.LectureId).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
