using Data.DataConnection;
using Data.Models.Models;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Services.ApiServices
{
    public class ScheduleService
    {
        private readonly ScheduleDbContext _dbContext;

        public ScheduleService(ScheduleDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void CreateNewSchedule(ScheduleDto schedule)
        {
            var ifExists = _dbContext.PracticeSchedules.Where(
                x => 
                    x.DayName == schedule.DayName &&
                    x.PracticeTime == schedule.PracticeTime &&
                    x.DanceGroupId == schedule.DanceGroupId
                ).FirstOrDefault();
            if(ifExists == null)
            {
                _dbContext.PracticeSchedules.Add(new PracticeSchedule()
                { 
                    DayName = schedule.DayName,
                    PracticeTime = schedule.PracticeTime,
                    DanceGroupId = schedule.DanceGroupId
                });
                _dbContext.SaveChanges();
            }
        }
        public List<ScheduleDto> GetAll()
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Select(x => new ScheduleDto
                {
                    DayName = x.DayName,
                    PracticeTime = x.PracticeTime,
                    DanceGroupId = x.DanceGroupId,
                    //DanceGroup = new DanceGroupDto
                    //{
                    //    DanceGroupName = x.DanceGroup.DanceGroupName,
                    //    Users = x.DanceGroup.Users.Select(y=> new UserDto 
                    //    { 
                    //        Email = y.Email,
                    //        FirstName = y.FirstName,
                    //        LastName = y.LastName,
                    //        PhoneNumber = y.PhoneNumber
                    //    }).ToList(),
                    //}
                }).ToList();
            }
        }

        public List<ScheduleDto> GetSchedulesByDayName(string dayName)
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Where(x => x.DayName == dayName).Select(y => new ScheduleDto
                {
                    DayName = y.DayName,
                    PracticeTime = y.PracticeTime,
                    DanceGroupId = y.DanceGroupId
                }).ToList();
            }
        }

        public List<ScheduleDto> GetScheduleByDanceGroupId(string groupId)
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Where(x => x.DanceGroupId == groupId).Select(y => new ScheduleDto
                {
                    DayName = y.DayName,
                    PracticeTime = y.PracticeTime,
                    DanceGroupId = y.DanceGroupId
                }).ToList();
            }
                
        }

        public void DeleteExistingSchedule(ScheduleDto schedule)
        {
            
        }
    }
}
