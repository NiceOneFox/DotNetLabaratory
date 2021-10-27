using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public record HomeworkBl
    {
        public int Id { get; init; }
        public string Text { get; init; }
        public DateTime DateTime { get; init; }
    }
}
