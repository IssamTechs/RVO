using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RVO.Services.Offices.Application;
using RVO.Services.Offices.Application.DTO;
using RVO.Services.Offices.Core.Entities;
using RVO.Services.Offices.Core.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace RVO.Services.Offices.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficesController : ControllerBase
    {
        private readonly IRepository _repository;

        public OfficesController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("")]
        [SwaggerOperation(
          Summary = "Gets a list of all offices",
          Description = "Gets a list of all offices",
          OperationId = "office.List",
          Tags = new[] { "offices" })
      ]
        public async Task<ActionResult<IEnumerable<OfficeDto>>> GetAll()
        {
            var offices = await _repository.ListAsync<Office>();
            return Ok(offices.Select(x=> x.AsDto()));
        }
    }
}
