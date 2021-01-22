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

        public bool CreateNewSchedule(ScheduleDto schedule)
        {
            var danceGroupID = _dbContext.DanceGroups.Where(
                        y => y.DanceGroupName == schedule.DanceGroupName
                        ).FirstOrDefault().ID;
            var ifExists = _dbContext.PracticeSchedules.Where(
                x =>
                    x.DayName == schedule.DayName &&
                    x.PracticeTime == schedule.PracticeTime &&
                    x.DanceGroupId == danceGroupID
                ).FirstOrDefault();
            if(ifExists == null)
            {
                _dbContext.PracticeSchedules.Add(new PracticeSchedule()
                { 
                    DayName = schedule.DayName,
                    PracticeTime = schedule.PracticeTime,
                    DanceGroupId = danceGroupID
                });
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public List<ScheduleDto> GetAll()
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Select(x => new ScheduleDto
                {
                    ScheduleID = x.ID,
                    DayName = x.DayName,
                    PracticeTime = x.PracticeTime,
                    DanceGroupId = x.DanceGroupId,
                    DanceGroupName = _dbContext.DanceGroups.Where(
                        y =>
                        y.ID == x.DanceGroupId
                        ).FirstOrDefault().DanceGroupName
                    
                }).ToList();
            }
        }

        public ScheduleDto GetScheduleById(string scheduleId)
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Where(x => x.ID == scheduleId).Select(y => new ScheduleDto
                {
                    DayName = y.DayName,
                    PracticeTime = y.PracticeTime,
                    DanceGroupId = y.DanceGroupId
                }).FirstOrDefault();
            }
        }

        public List<ScheduleDto> GetSchedulesByPracticeTime(string time)
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Where(x => x.PracticeTime == time).Select(y => new ScheduleDto
                {
                    DayName = y.DayName,
                    PracticeTime = time,
                    DanceGroupId = y.DanceGroupId
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

        public List<ScheduleDto> GetSchedulesByDanceGroupId(string groupId)
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

        public bool DeleteExistingSchedule(ScheduleDto schedule)
        {
            var danceGroupID = _dbContext.DanceGroups.Where(
                        y => y.DanceGroupName == schedule.DanceGroupName
                        ).FirstOrDefault().ID;
            var ifExists = _dbContext.PracticeSchedules.Where(
                x =>
                    x.DayName == schedule.DayName &&
                    x.PracticeTime == schedule.PracticeTime &&
                    x.DanceGroupId == danceGroupID
                ).FirstOrDefault();
            if (ifExists != null)
            {
                _dbContext.PracticeSchedules.Remove(ifExists);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateExistingSchedule(ScheduleDto schedule)
        {
            var ifExists = _dbContext.PracticeSchedules.Where(
                x => x.ID == schedule.ScheduleID
                ).FirstOrDefault();
            if (ifExists != null)
            {
                ifExists.DayName = schedule.DayName;
                ifExists.PracticeTime = schedule.PracticeTime;
                ifExists.DanceGroupId = schedule.DanceGroupId;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
