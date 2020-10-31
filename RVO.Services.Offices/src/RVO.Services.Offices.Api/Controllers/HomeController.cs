using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.Annotations;

namespace RVO.Services.Offices.Api.Controllers
{ 
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        } 
        [SwaggerOperation(
      Summary = "Service Home",
      Description = "Service Home",
      OperationId = "office Service",
      Tags = new[] { "office service" })
  ]
        [HttpGet]
        public IActionResult Get() => Ok(_configuration.GetSection("app").Get<AppOptions>().Name);
    }
}
