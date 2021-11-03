using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Models;
using AutoMapper;
using WebApplicationStudents.Exceptions;
using CourseExceptions;
using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService _markService;

        private readonly ILogger<MarkController> _logger;

        private readonly IMapper _mapper;

        public MarkController(IMarkService markService, ILogger<MarkController> logger, IMapper mapper)
        {
            _markService = markService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("id")]
        public ActionResult<MarkBl> GetMark(int id)
        {
            return _markService.Get(id) switch
            {
                null => throw new NotFoundInstanceException($"Instance Mark with {id} was not found"),
                var mark => mark
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<MarkBl>> GetMarks()
        {
            return _markService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddMark(Mark mark)
        {
            var newMarkId = _markService.New(_mapper.Map<MarkBl>(mark));
            return Ok($"api/mark/{newMarkId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateMark(int id, Mark mark)
        {
            var markBl = _mapper.Map<MarkBl>(mark);
            var editedMark = _markService.Edit(markBl with { Id = id });
            return Ok(editedMark);
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteMark(int id)
        {
            _markService.Delete(id);
            return Ok();
        }
    }
}
