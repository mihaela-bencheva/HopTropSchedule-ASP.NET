using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ApiServices;
using Services.DTOModels;

namespace ScheduleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService service;
        public UserController(UserService service)
        {
            this.service = service;
        }

        //api/user/getall
        [Authorize]
        [Route("getall/{groupId}")]
        [HttpGet]
        public IActionResult GetAllUsersByGroupId(string groupId)
        {
            var result = service.GetAllUsersByGroupId(groupId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //api/user/update
        [Route("update")]
        [HttpPost]
        public IActionResult UpdateExistingUser(UserDto user)
        {
            var result = service.UpdateExistingUser(user);
            if (result)
            {
                return Ok("The object has been successfully updated.");
            }
            return BadRequest("Something went wrong!");
        }
    }
}