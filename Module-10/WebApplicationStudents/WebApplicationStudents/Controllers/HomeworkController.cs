using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
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
    public class HomeworkController : ControllerBase
    {
        private readonly IHomeworkService _homeworkService;

        private readonly ILogger<HomeworkController> _logger;

        private readonly IMapper _mapper;
        public HomeworkController(IHomeworkService homeworkService, ILogger<HomeworkController> logger, IMapper mapper)
        {
            _homeworkService = homeworkService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("id")]
        public ActionResult<HomeworkBl> GetHomework(int id)
        {       
            return _homeworkService.Get(id) switch
            {
                null => throw new NotFoundInstanceException($"Instance Homework with {id} was not found"),
                var homework => homework
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<HomeworkBl>> GetHomeworks()
        {
            return _homeworkService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddHomework(Homework homework)
        {
            var newHomeworkId = _homeworkService.New(_mapper.Map<HomeworkBl>(homework));
            return Ok($"api/homework/{newHomeworkId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateHomework(int id, Homework homework)
        {         
            var homeworkBl = _mapper.Map<HomeworkBl>(homework);
            var homeworkId = _homeworkService.Edit(homeworkBl with { Id = id });
            return Ok($"api/homework/{homeworkId}");
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteHomework(int id)
        {
            _homeworkService.Delete(id);
            return Ok();
        }
    }
}
