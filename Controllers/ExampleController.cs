using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keycloak_Example_NetCore.Api1.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/example")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("claims")]
        public IActionResult Get()
        {
            return Ok(new { api1Result = (User.Identity as ClaimsIdentity).Claims.Select(c => new KeyValuePair<string,string>(c.Type, c.Value))
                .Append(new KeyValuePair<string, string>("token", HttpContext.GetTokenAsync("access_token").Result)) });
        }
    }
}
