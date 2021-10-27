using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Models;
using AutoMapper;
using WebApplicationStudents.Exceptions;
using CourseExceptions;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;

        private readonly ILogger _logger;

        private readonly IMapper _mapper;

        public LectureController(ILectureService lectureService, ILogger<LectureController> logger, IMapper mapper)
        {
            _lectureService = lectureService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")] 
        public ActionResult<LectureBl> GetLecture(int id)
        {
            _logger.LogTrace("GetLecture method");
            if (id <= 0) throw new IndexLessThanZeroException($"Id {id} of Lecture was less than zero");                         
           
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
        public ActionResult AddLecture(Lecture lecture)
        {
            var newLectureId = _lectureService.New(_mapper.Map<LectureBl>(lecture));
            return Ok($"api/lecture/{newLectureId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateLecture(int id, Lecture lecture)
        {
            if (id <= 0) throw new IndexLessThanZeroException($"Id {id} of Lecture was less than zero");

            var lectureBl = _mapper.Map<LectureBl>(lecture);
            var lectureId = _lectureService.Edit(lectureBl with { Id = id });
           
            return Ok($"api/lecture/{lectureId}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLecture(int id)
        {
            if (id <= 0) throw new IndexLessThanZeroException($"Id {id} of Lecture was less than zero");

            _lectureService.Delete(id);
            return Ok();
        }

    }
}
