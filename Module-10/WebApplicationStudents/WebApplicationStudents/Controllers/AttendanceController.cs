using BusinessLogic.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using System.Text.Json;
using WebApplicationStudents.Models;
using AutoMapper;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [FormatFilter]
    [Route("[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _serviceAttendance;

        private readonly ILogger<AttendanceController> _logger;

        private readonly IMapper _mapper;

        public AttendanceController(IAttendanceService serviceAttendance, ILogger<AttendanceController> logger, IMapper mapper)
        {
            _serviceAttendance = serviceAttendance;
            _logger = logger;
            _mapper = mapper;
        }

        // Генерация репорта о посещаемости, по названию лекции или по имени студента. Отчет поддерживает 2 формата - Xml / Json (формат свободный). 
        [HttpGet(".{format?}")]
        public IActionResult GetReport(string orderBy, string name) // student "Ivan" // lecture "Docker"
        {
            var result = _serviceAttendance.GetReportOfAttendance(orderBy, name);

            if (!result.Any() || result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
