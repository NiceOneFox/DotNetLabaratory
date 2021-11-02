using BusinessLogic;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLogic.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Validation;
using AutoMapper;
using WebApplicationStudents.Models;
using WebApplicationStudents.Exceptions;
using CourseExceptions;

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LectorController : ControllerBase
    {
        private readonly ILectorService _lectorService;

        private readonly ILogger<LectorController> _logger;

        private readonly IMapper _mapper;

        public LectorController(ILectorService lectorService, ILogger<LectorController> logger, IMapper mapper)
        {
            _lectorService = lectorService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<LectorBl> GetLector(int id)
        {
            return _lectorService.Get(id) switch
            {
                null => NotFound(),
                var lector => lector // implicit cast to AcitonResult
            };
        }

        [HttpGet]
        public ActionResult<IReadOnlyCollection<LectorBl>> GetLectors()
        {
            return _lectorService.GetAll().ToArray();
        }

        [HttpPost]
        public ActionResult AddLector(Lector lector)
        {
            var newLectorId = _lectorService.New(_mapper.Map<LectorBl>(lector));
            return Ok($"api/lector/{newLectorId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateLector(int id, Lector lector)
        {        
            var lectorBl = _mapper.Map<LectorBl>(lector) with { Id = id };
            var editedLector = _lectorService.Edit(lectorBl);

            return Ok(editedLector);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLector(int id)
        {     
            _lectorService.Delete(id);
            return Ok();
        }

    }
}
