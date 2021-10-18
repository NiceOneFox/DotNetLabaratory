using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentService studentService, ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            return _studentService.Get(id) switch
            {
                null => NotFound(),
                var student => student // implicit cast to AcitonResult
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<Student>> GetStudents()
        {
            return _studentService.GetAll().ToArray();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            var newStudentId = _studentService.New(student);
            return Ok($"api/student/{newStudentId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateStudent(int id, Student student)
        {
            var studentId = _studentService.Edit(student with { Id = id });
            return Ok($"api/student/{studentId}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            _studentService.Delete(id);
            return Ok();
        }

    }
}
