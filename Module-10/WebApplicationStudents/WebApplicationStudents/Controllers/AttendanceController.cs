using BusinessLogic.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [FormatFilter]
    [Route("[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly IServiceAttendance _serviceAttendance;

        private readonly ILogger<AttendanceController> _logger;

        public AttendanceController(IServiceAttendance serviceAttendance, ILogger<AttendanceController> logger)
        {
            _serviceAttendance = serviceAttendance;
            _logger = logger;
        }

        // Генерация репорта о посещаемости, по названию лекции или по имени студента. Отчет поддерживает 2 формата - Xml / Json (формат свободный). 
        [HttpGet(".{format?}")]
        public IActionResult GetReport(string orderBy, string name) // student "Ivan"
        {
            //var result = _serviceAttendance.GetByPartialName(fragment);
            //if (!result.Any())
            //{
            //    return NotFound(fragment);
            //}
            //return Ok(result);
            //var result = _authors.GetByNameSubstring(namelike);
            //if (!result.Any())
            //{
            //    return NotFound(namelike);
            //}
            return Ok();
           
        }
    }
}
