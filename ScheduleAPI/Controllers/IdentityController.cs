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
    [Authorize]
    public class IdentityController : ControllerBase
    {
        private readonly IdentityService identityService;
        public IdentityController(IdentityService identityService)
        {
            this.identityService = identityService;
        }
        public IActionResult Register(UserDto model)
        {
            var token = identityService.RegisterUser(model);
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}