using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ServiceInterfaces
{
    public interface IAttendanceService
    {
        public IEnumerable<object> GetReportOfAttendance(string orderby, string name);
    }
}
