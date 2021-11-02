using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public class SeriesDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Text { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public LectorDb Lector { get; set; }        
        public int LectorId { get; set; }
        public ICollection<LectureDb> Lectures { get; set; }
    }
}
