using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ApiServices;
using Services.DTOModels;

namespace ScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolkDanceController : ControllerBase
    {
        private readonly DanceService service;
        public FolkDanceController(DanceService service)
        {
            this.service = service;
        }

        //api/folkdance/create
        [Route("create")]
        [HttpPost]
        public IActionResult CreateNewDance([FromBody]FolkDanceDto folk)
        {
            var result = service.CreateNewDance(folk);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        //api/folkdance/delete
        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteExistingDance([FromBody]FolkDanceDto folk)
        {
            var result = service.DeleteExistingDance(folk);
            if (result)
            {
                return Ok("The object has been deleted.");
            }
            return BadRequest("Something went wrong!");
        }

        //api/folkdance/update
        [Route("update")]
        [HttpPut]
        public IActionResult UpdateExistingDance([FromBody]FolkDanceDto folk)
        {
            var result = service.UpdateExistingDance(folk);

            if (result)
            {
                return Ok("The object has been successfully updated.");
            }
            return BadRequest("Something went wrong!");
        }

        //api/folkdance/getall
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAllDances()
        {
            var dances = service.GetAllDances();
            if (dances != null)
            {
                return Ok(dances);
            }
            return BadRequest();
        }
    }
}