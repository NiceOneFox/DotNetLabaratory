using BusinessLogic.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.RepositoryInterfaces;

namespace BusinessLogic.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceService(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }
        public IReadOnlyCollection<object> GetReportOfAttendance(string orderby, string name)
        {
            return (IReadOnlyCollection<object>)_attendanceRepository.GetReport(orderby, name);
        }
    }
}
