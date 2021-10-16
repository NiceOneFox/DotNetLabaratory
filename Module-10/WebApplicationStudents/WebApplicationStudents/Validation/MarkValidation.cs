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
            RuleFor(x => x.Assesment).NotEmpty().NotNull().GreaterThan(-1).LessThan(5).
                WithMessage("Assesment value must be between 0 and 5");
            RuleFor(x => x.Text).MaximumLength(255);
        }
    }
}
