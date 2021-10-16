using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Validation
{
    public class HomeworkValidation : AbstractValidator<Homework>
    {
        public HomeworkValidation()
        {
            RuleFor(x => x.DeadLine).NotEmpty().NotNull().GreaterThan(DateTime.Now).WithMessage("Deadline date must be in future");
            RuleFor(x => x.Text).NotEmpty().NotNull().MaximumLength(255);
        }
    }
}
