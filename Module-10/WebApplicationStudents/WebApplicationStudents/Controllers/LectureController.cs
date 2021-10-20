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
    [ApiController]
    [Route("[Controller]")]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;

        private readonly ILogger _logger;

        public LectureController(ILectureService lectureService, ILogger logger)
        {
            _lectureService = lectureService;
            _logger = logger;
        }

        [HttpGet("{id}")] 
        public ActionResult<LectureBl> GetLecture(int id)
        {
            return _lectureService.Get(id) switch
            {
                null => NotFound(),
                var lecture => lecture // implicit cast to AcitonResult
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<LectureBl>> GetLectures()
        {
            return _lectureService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddLecture(LectureBl lecture)
        {
            var newLectureId = _lectureService.New(lecture);
            return Ok($"api/lecture/{newLectureId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateLecture(int id, LectureBl lecture)
        {
            var lectureId = _lectureService.Edit(lecture with { Id = id });
            return Ok($"api/lecture/{lectureId}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLecture(int id)
        {
            _lectureService.Delete(id);
            return Ok();
        }

    }
}
