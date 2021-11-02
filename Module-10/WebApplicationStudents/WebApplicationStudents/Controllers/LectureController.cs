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
            var lectureBl = _mapper.Map<LectureBl>(lecture);
            var editedLecture = _lectureService.Edit(lectureBl with { Id = id });
           
            return Ok(editedLecture);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLecture(int id)
        {       
            _lectureService.Delete(id);
            return Ok();
        }

    }
}
