using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public record LectorDb
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }


        public SeriesDb Series { get; set; }

        public int SeriesId { get; set; }

        //public ICollection<LectureDb> Lectures { get; set; }
    }
}
