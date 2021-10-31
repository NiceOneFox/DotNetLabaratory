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
using BusinessLogic.EmailSender;

namespace BusinessLogic.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        private readonly IMapper _mapper;

        private readonly IEmailService _emailService;

        private const int allowedSkipLections = 3;
        public AttendanceService(IAttendanceRepository attendanceRepository, IMapper mapper, IEmailService emailService)
        {
            _attendanceRepository = attendanceRepository;
            _mapper = mapper;
            _emailService = emailService;
        }

        public IReadOnlyCollection<object> GetReportOfAttendance(string orderby, string name)
        {
            return (IReadOnlyCollection<object>)_attendanceRepository.GetReport(orderby, name);
        }

        public void Edit(AttendanceBl attendance)
        {
            _attendanceRepository.Edit(_mapper.Map<AttendanceDb>(attendance));
        }

        public void New(AttendanceBl attendance)
        {
            throw new NotImplementedException();
            _attendanceRepository.New(_mapper.Map<AttendanceDb>(attendance));

            if (_attendanceRepository.SkippedLectures(allowedSkipLections) is StudentBl studentBl) // null if not EmailStudent if skipped more
            {
                _emailService.SendEmailAsync(studentBl.Email, "Attendance of Lectures", "You have missed more than 3 lectures of Course.");
            } 
        }
    }
}
