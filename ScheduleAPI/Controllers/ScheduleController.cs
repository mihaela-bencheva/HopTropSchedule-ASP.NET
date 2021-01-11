using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ApiServices;
using Services.DTOModels;

namespace ScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleService scheduleService;

        public ScheduleController(ScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }   

        //api/schedule/create
        [Route("create")]
        [HttpPost]
        public IActionResult CreateNewSchedule([FromBody]ScheduleDto schedule)
        {
            var result = scheduleService.CreateNewSchedule(schedule);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        //api/schedule/delete
        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteExistingSchedule([FromBody]ScheduleDto schedule)
        {
            var result = scheduleService.DeleteExistingSchedule(schedule);
            if (result)
            {
                return Ok("The object has been deleted.");
            }
            return BadRequest("Something went wrong!");
        }

        //api/schedule/update
        [Route("update")]
        [HttpPut]
        public IActionResult UpdateExistingSchedule([FromBody]ScheduleDto schedule)
        {
            var result = scheduleService.UpdateExistingSchedule(schedule);

            if (result)
            {
                return Ok("The object has been successfully updated.");
            }
            return BadRequest("Something went wrong!");
        }

        //api/schedule/getall
        [Route("getall")]
        [HttpGet]
        public IActionResult GetAllSchedules()
        {
            var schedules = scheduleService.GetAll();
            if (schedules != null)
            {
                return Ok(schedules);
            }
            return BadRequest();
        }
    }
}