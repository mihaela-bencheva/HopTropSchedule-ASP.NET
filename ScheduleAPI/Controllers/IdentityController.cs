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

        //api/identity/register
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

        //api/identity/register
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

        //api/identity/pwdchange
        [Route("pwdchange")]
        [HttpPost]
        public IActionResult UserChangePassword(RegisterDto register)
        {
            var result = identityService.UserChangePassword(register);
            if (result)
            {
                return Ok("Password has been changed successfully!");
            }
            return BadRequest("Something went wrong!");
        }
    }
}