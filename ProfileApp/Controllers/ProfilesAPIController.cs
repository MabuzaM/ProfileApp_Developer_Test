using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProfileApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfilesAPIController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public ProfilesAPIController()
        {
            
        }

        private readonly ILogger<ProfilesAPIController> _logger;

        public ProfilesAPIController(ILogger<ProfilesAPIController> logger)
        {
            _logger = logger;
        }

    }
}
