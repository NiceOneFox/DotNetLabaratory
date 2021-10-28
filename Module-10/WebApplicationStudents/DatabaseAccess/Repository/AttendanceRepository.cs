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
            if (orderBy == "lecture")
            {
                return _context.Lectures.Include(l => l.Students).
                    Where(l => l.Name == name).ToList();
            } 
            else if (orderBy == "student")
            {
                return _context.Students.Include(s => s.Lectures)
               .Where(s =>s.FirstName == name).ToList();
            }
            return null;
        }
    }
}
