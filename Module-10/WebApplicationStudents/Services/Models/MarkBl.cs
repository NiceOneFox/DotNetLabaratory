using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public record MarkBl
    {
        public int Id { get; init; }
        public int? Assesment { get; init; }
        public string? Text { get; init; }
    }
}
