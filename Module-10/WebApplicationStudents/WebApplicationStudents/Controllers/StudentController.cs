﻿using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WebApplicationStudents.Models;
using AutoMapper;
using WebApplicationStudents.Exceptions;

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
            if (id <= 0) throw new IndexLessThanZeroException($"Id {id} of Student was less than zero");

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
        public ActionResult AddStudent(Student student)
        {
            var newStudentId = _studentService.New(_mapper.Map<StudentBl>(student));
            return Ok($"api/student/{newStudentId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateStudent(int id, Student student)
        {
            if (id <= 0) throw new IndexLessThanZeroException($"Id {id} of Student was less than zero");

            var studentBl = _mapper.Map<StudentBl>(student);
            var studentId = _studentService.Edit(studentBl with { Id = id });
            return Ok($"api/student/{studentId}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            if (id <= 0) throw new IndexLessThanZeroException($"Id {id} of Student was less than zero");

            _studentService.Delete(id);
            return Ok();
        }

    }
}
