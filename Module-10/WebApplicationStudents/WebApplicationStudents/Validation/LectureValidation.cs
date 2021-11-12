using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Validation
{
    public class LectureValidation : AbstractValidator<Lecture>
    {
        public LectureValidation()
        {
            RuleFor(x => x.Date).NotEmpty().GreaterThan(DateTime.Now).WithMessage("Date of lecture must be in future");
            RuleFor(x => x.Name).Length(2, 120);
            RuleFor(x => x.HomeworkId).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.SeriesId).NotEmpty().NotNull().GreaterThan(0);
        }

    }
}
