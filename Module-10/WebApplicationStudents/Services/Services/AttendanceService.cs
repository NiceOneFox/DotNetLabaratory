using BusinessLogic.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.RepositoryInterfaces;
using BusinessLogic.Models;
using AutoMapper;
using DatabaseAccess.Models;

namespace BusinessLogic.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        private readonly IMapper _mapper;

        public AttendanceService(IAttendanceRepository attendanceRepository, IMapper mapper)
        {
            _attendanceRepository = attendanceRepository;
            _mapper = mapper;
        }

        public IReadOnlyCollection<object> GetReportOfAttendance(string orderby, string name)
        {
            return (IReadOnlyCollection<object>)_attendanceRepository.GetReport(orderby, name);
        }

        public void Edit(AttendanceBl attendance)
        {
            throw new NotImplementedException();
        }

        public void New(AttendanceBl attendance)
        {
            throw new NotImplementedException();
        }
    }
}
