using DatabaseAccess.Models;
using DatabaseAccess.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseExceptions;

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
                        Attendance = a.IsAttend

                    })
                    .Where(s => (orderBy == "student") ? (s.FirstName == name) : true)
                    .Where(s => (orderBy == "lecture") ? (s.LectureName == name) : true).ToList();

        }

        public void Edit(AttendanceDb attendance)
        {
            if (_context.Attendances.Find(attendance.StudentId, attendance.LectureId)
                is AttendanceDb attendanceInDb)
            {
                attendanceInDb.IsAttend = attendance.IsAttend;
                _context.Entry(attendanceInDb).State = EntityState.Modified;
                _context.SaveChanges();
            }
            else
            {
                throw new NotFoundInstanceException();
            }
        }

        public void New(AttendanceDb attendance)
        {
             _context.Attendances.Add(attendance);
            _context.SaveChanges();
        }

        public int? SkippedLectures(int studentId)
        {
           return _context.Attendances.Where(a => a.StudentId == studentId && a.IsAttend == false).Count();
        }

    }
}
