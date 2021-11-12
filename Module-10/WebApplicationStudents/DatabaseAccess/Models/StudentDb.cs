using System.Collections.Generic;

namespace DatabaseAccess.Models
{
    public record StudentDb
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public int Score { get; set; }


        public ICollection<LectureDb> Lectures { get; set; }

        public ICollection<AttendanceDb> Attendances { get; set; }

        public ICollection<MarkDb> Marks { get; set; }
    }
}
