using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.ServiceInterfaces
{
    public interface IAttendanceService
    {
        IReadOnlyCollection<object> GetReportOfAttendance(string orderby, string name);
        void New(AttendanceBl attendance);
        void Edit(AttendanceBl attendance);
    }
}
