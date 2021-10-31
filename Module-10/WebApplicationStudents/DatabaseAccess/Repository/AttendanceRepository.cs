using DatabaseAccess.Models;
using DatabaseAccess.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.Repository
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly CourseDbContext _context;

        public AttendanceRepository(CourseDbContext context)
        {
            _context = context;
        }

        public IEnumerable<object> GetReport(string orderBy, string name)
        {
            return (from a in _context.Attendances
                    join s in _context.Students on a.Student.Id equals s.Id
                    join l in _context.Lectures on a.Lecture.Id equals l.Id
                    //where s.FirstName == name                    
                    select new
                    {
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email,
                        LectureName = l.Name,
                        LectureDate = l.Date,
                        Attendance = a.isAttend
                        
                    })
                    .Where(s => (orderBy == "student") ? (s.FirstName == name) : true)
                    .Where(s => (orderBy == "lecture") ? (s.LectureName == name) : true).ToList();

        }

        public void Edit(AttendanceDb attendance)
        {
            throw new NotImplementedException();
        }

        public void New(AttendanceDb attendance)
        {
            throw new NotImplementedException();
        }
    }
}
