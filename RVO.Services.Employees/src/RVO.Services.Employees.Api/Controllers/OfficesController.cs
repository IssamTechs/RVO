using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RVO.Services.Employees.Application;
using RVO.Services.Employees.Application.DTO;
using RVO.Services.Employees.Core.Entities;
using RVO.Services.Employees.Core.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace RVO.Services.Employees.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepository _repository;

        public EmployeesController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("")]
        [SwaggerOperation(
          Summary = "Gets a list of all Employees",
          Description = "Gets a list of all Employees",
          OperationId = "Employee.List",
          Tags = new[] { "Employees" })
      ]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetAll()
        {
            var Employees = await _repository.ListAsync<Employee>();
            return Ok(Employees.Select(x=> x.AsDto()));
        }
    }
}
