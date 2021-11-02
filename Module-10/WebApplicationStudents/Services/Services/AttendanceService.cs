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
using DatabaseAccess.Repository;
using CourseExceptions;

namespace BusinessLogic.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        private readonly IStudentRepository _studentRepository;

        private readonly IMapper _mapper;

        private readonly IEmailService _emailService;

        private const int allowedSkipLections = 3;

        public AttendanceService(IAttendanceRepository attendanceRepository, IStudentRepository studentRepository, IMapper mapper, IEmailService emailService)
        {
            _attendanceRepository = attendanceRepository;
            _studentRepository = studentRepository;
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
            CheckSkippedLectures(attendance);
        }

        public void New(AttendanceBl attendance)
        {
            _attendanceRepository.New(_mapper.Map<AttendanceDb>(attendance));
            CheckSkippedLectures(attendance);
        }

        public void CheckSkippedLectures(AttendanceBl attendance)
        {
            if (_attendanceRepository.SkippedLectures(attendance.StudentId) > allowedSkipLections)
            {
                var studentDb = _studentRepository.Get(attendance.StudentId);
                var lectorEmail = _attendanceRepository.GetEmailLector(attendance.LectureId);
                if (studentDb is null)
                {
                    throw new NotFoundInstanceException($"Instance {nameof(studentDb)} with Id {attendance.StudentId} was not found in context");
                }
                if (lectorEmail is null)
                {
                    throw new NotFoundInstanceException($"Instance of lecture with {attendance.LectureId} was not found");
                }
                _emailService.SendEmailAsync(studentDb.Email, "Attendance of Lectures", "You have missed more than 3 lectures of Course.");
                _emailService.SendEmailAsync(lectorEmail, "Attendance of Lectures.", 
                    $"Your Student: {studentDb.FirstName + " " + studentDb.LastName} has missed more than 3 lectures of Course.");
            }
        }
    }
}
