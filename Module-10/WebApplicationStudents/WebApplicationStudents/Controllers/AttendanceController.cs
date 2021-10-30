using BusinessLogic.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using System.Text.Json;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [FormatFilter]
    [Route("[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _serviceAttendance;

        private readonly ILogger<AttendanceController> _logger;

        public AttendanceController(IAttendanceService serviceAttendance, ILogger<AttendanceController> logger)
        {
            _serviceAttendance = serviceAttendance;
            _logger = logger;
        }

        // Генерация репорта о посещаемости, по названию лекции или по имени студента. Отчет поддерживает 2 формата - Xml / Json (формат свободный). 
        [HttpGet(".{format?}")]
        public IActionResult GetReport(string orderBy, string name) // student "Ivan"
        {
            var result = _serviceAttendance.GetReportOfAttendance(orderBy, name);

            if (!result.Any() || result is null)
            {
                return NotFound();
            }
            var jsonResult = JsonSerializer.Serialize(result);
            return Ok(jsonResult);           
        }
    }
}
