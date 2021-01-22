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

        //api/user/getall/{groupId}
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
        [HttpPut]
        public IActionResult UpdateExistingUser(UserDto user)
        {
            var result = service.UpdateExistingUser(user);
            if (result)
            {
                return Ok("The object has been successfully updated.");
            }
            return BadRequest("Something went wrong!");
        }

        //api/user/getallusers
        [Route("getallusers")]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = service.GetAllUsers();
            if (users != null)
            {
                return Ok(users);
            }
            return BadRequest();
        }

        //api/user/delete
        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteExistingUser(UserEmailDto user)
        {
            var result = service.DeleteExistingUser(user);
            if (result)
            {
                return Ok("The object has been deleted successfully");
            }
            return BadRequest("Something went wrong!");
        }

        //api/user/getbyid/{userId}
        [Route("getbyid/{userId}")]
        [HttpGet]
        public IActionResult GetUserById(string userId)
        {
            var user = service.GetUserById(userId);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest();
        }
    }
}