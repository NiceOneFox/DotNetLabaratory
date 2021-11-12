using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WebApplicationStudents.Models;
using AutoMapper;
using WebApplicationStudents.Exceptions;
using CourseExceptions;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        private readonly ILogger<StudentController> _logger;

        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, ILogger<StudentController> logger, IMapper mapper)
        {
            _studentService = studentService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<StudentBl> GetStudent(int id)
        {
            return _studentService.Get(id) switch
            {
                null => throw new NotFoundInstanceException($"Instance Student with {id} was not found"),
                var student => student // implicit cast to AcitonResult
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<StudentBl>> GetStudents()
        {
            return _studentService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            var newStudentId = _studentService.New(_mapper.Map<StudentBl>(student));
            return Ok($"api/student/{newStudentId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateStudent(int id, Student student)
        {
            var studentBl = _mapper.Map<StudentBl>(student);
            var editedStudent = _studentService.Edit(studentBl with { Id = id });
            return Ok(editedStudent);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            _studentService.Delete(id);
            return Ok();
        }

    }
}
