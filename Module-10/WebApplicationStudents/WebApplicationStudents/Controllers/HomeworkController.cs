using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationStudents.Controllers
{
    public class HomeworkController : ControllerBase
    {
        private readonly IHomeworkService _homeworkService;

        private readonly ILogger<HomeworkController> _logger;
        public HomeworkController(IHomeworkService homeworkService, ILogger<HomeworkController> logger)
        {
            _homeworkService = homeworkService;
            _logger = logger;
        }

        [HttpGet("id")]
        public ActionResult<Homework> GetHomework(int id)
        {
            return _homeworkService.Get(id) switch
            {
                null => NotFound(),
                var homework => homework
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<Homework>> GetHomeworks()
        {
            return _homeworkService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddHomework(Homework homework)
        {
            var newHomeworkId = _homeworkService.New(homework);
            return Ok($"api/homework/{newHomeworkId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateHomework(int id, Homework homework)
        {
            var homeworkId = _homeworkService.Edit(homework with { Id = id });
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
