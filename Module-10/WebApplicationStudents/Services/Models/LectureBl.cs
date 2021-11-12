using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public record LectureBl
    {
        public int Id { get; init; }
        public DateTime Date { get; init; }
        public string Name { get; init; }

        public int HomeworkId { get; init; }
        public int SeriesId { get; init; }
    }
}
