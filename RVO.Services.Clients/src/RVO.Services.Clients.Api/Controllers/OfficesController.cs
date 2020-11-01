using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RVO.Services.Clients.Application;
using RVO.Services.Clients.Application.DTO;
using RVO.Services.Clients.Core.Entities;
using RVO.Services.Clients.Core.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace RVO.Services.Clients.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IRepository _repository;

        public ClientsController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("")]
        [SwaggerOperation(
          Summary = "Gets a list of all Clients",
          Description = "Gets a list of all Clients",
          OperationId = "Client.List",
          Tags = new[] { "Clients" })
      ]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetAll()
        {
            var Clients = await _repository.ListAsync<Client>();
            return Ok(Clients.Select(x=> x.AsDto()));
        }
    }
}
