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

namespace WebApplicationStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LectorController : ControllerBase
    {
        private readonly ILectorService _lectorService;

        private readonly ILogger<LectorController> _logger;

        public LectorController(ILectorService lectorService, ILogger<LectorController> logger)
        {
            _lectorService = lectorService;
            _logger = logger;
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
        public ActionResult AddLector(LectorBl lector)
        {
            var newLectorId = _lectorService.New(lector);
            return Ok($"api/lector/{newLectorId}");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateLector(int id, LectorBl lector)
        {
            var lectorId = _lectorService.Edit(lector with { Id = id });
            return Ok($"api/lector/{lectorId}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLector(int id)
        {
            _lectorService.Delete(id);
            return Ok();
        }

    }
}
