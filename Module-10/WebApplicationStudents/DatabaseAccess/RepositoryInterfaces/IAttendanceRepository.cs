using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.RepositoryInterfaces
{
    public interface IAttendanceRepository
    {
        IEnumerable<object> GetReport(string orderBy, string name);
        void Edit(AttendanceDb attendance);
        void New(AttendanceDb attendance);
    }
}
