using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Validation
{
    public class LectorValidation : AbstractValidator<Lector>
    {
        public LectorValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().NotNull().Length(2, 30);
            RuleFor(x => x.LastName).NotEmpty().NotNull().Length(2, 30);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Position).NotEmpty().Length(4, 26);
        }
    }
}
