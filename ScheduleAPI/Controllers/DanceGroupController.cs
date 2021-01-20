using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Services.ApiServices;
using Services.DTOModels;

namespace ScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanceGroupController : ControllerBase
    {
        private readonly GroupService groupService;
        private readonly IWebHostEnvironment webHost;

        public DanceGroupController(GroupService groupService, IWebHostEnvironment webHost)
        {
            this.groupService = groupService;
            this.webHost = webHost;
        }

        //api/dancegroup/create
        [Route("create")]
        [HttpPost]
        public IActionResult CreateNewDanceGroup([FromForm]DanceGroupDto group)
        {
            var result = groupService.CreateNewDanceGroup(group, "wwwroot\\");
            if (result.Result)
            {
                return Ok();
            }
            return BadRequest();
        }

        //api/dancegroup/delete
        [Route("delete")]
        [HttpPost]
        public IActionResult DeleteExistingDanceGroup([FromBody]DanceGroupDto group)
        {
            var result = groupService.DeleteExistingDanceGroup(group);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        //api/dancegroup/update
        [Route("update")]
        [HttpPut]
        public IActionResult UpdateExistingDanceGroup([FromBody]DanceGroupDto group)
        {
            var result = groupService.UpdateExistingDanceGroup(group);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        //api/dancegroup/group
        [Route("group")]
        [HttpPost]
        public IActionResult FindGroupByName(string danceGroup)
        {
            var result = groupService.FindGroupByName(danceGroup);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //api/dancegroup/upload
        [Route("upload")]
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm]IFormFile form)
        {
            string image = form.FileName;
            string path = Path.Combine("~/wwwroot/", "Images/Groups", image);
            using(var stream = new FileStream(path, FileMode.Create))
            {
                await form.CopyToAsync(stream);
            }
            byte[] array;
            using(var memoryStream = new MemoryStream())
            {
                await form.CopyToAsync(memoryStream);
                array = memoryStream.ToArray();
            }
            return Ok(array);
        }

        //api/dancegroup/getAll
        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAllGroups()
        {
            var groups = groupService.GetAllGroups();
            if(groups != null)
            {
                return Ok(groups);
            }
            return BadRequest();
        }

        //api/dancegroup/details
        //[Route("details")]
        [HttpGet("details/{groupName}")]
        public IActionResult GetGroupDetails(string groupName)
        {
            var groups = groupService.GetGroupDetails(groupName);
            if (groups != null)
            {
                return Ok(groups);
            }
            return BadRequest();
        }
    }
}