using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Validation;
using FluentValidation.Results;

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
        public ActionResult<StudentBl> GetStudent(int id)
        {
            return _studentService.Get(id) switch
            {
                null => NotFound(),
                var student => student // implicit cast to AcitonResult
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<StudentBl>> GetStudents()
        {
            return _studentService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddStudent(Models.Student student)
        {
            var validator = new StudentValidator();
            var result = validator.Validate(student);
            if (result.IsValid)
            {
                var newStudentId = _studentService.New(student);
                return Ok($"api/student/{newStudentId}");
            } else
            {
                foreach (ValidationFailure failer in result.Errors)
                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                }
            }
             
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateStudent(int id, StudentBl student)
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
