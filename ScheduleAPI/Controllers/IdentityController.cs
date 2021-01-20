using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTOModels;

namespace ScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IdentityService identityService;
        public IdentityController(IdentityService identityService)
        {
            this.identityService = identityService;
        }
        [Route("register")]
        [HttpPost]
        public IActionResult Register(RegisterDto model)
        {
            var token = identityService.RegisterUser(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(UserDto user)
        {
            var token = identityService.LogInUser(user);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}