using DatabaseAccess.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //return _context.Students.Join()
            return null;
        }
    }
}
