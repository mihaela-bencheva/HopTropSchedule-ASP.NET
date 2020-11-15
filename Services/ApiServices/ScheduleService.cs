using Data.DataConnection;
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

        public List<ScheduleDto> GetAll()
        {
            using (_dbContext)
            {
                return _dbContext.PracticeSchedules.Select(x => new ScheduleDto
                {
                    DayName = x.DayName,
                    PracticeTime = x.PracticeTime,
                    DanceGroupId = x.DanceGroupId,
                    DanceGroup = new DanceGroupDto
                    {
                        DanceGroupName = x.DanceGroup.DanceGroupName,
                        Users = x.DanceGroup.Users.Select(y=> new UserDto 
                        { 
                            Email = y.Email,
                            FirstName = y.FirstName,
                            LastName = y.LastName,
                            PhoneNumber = y.PhoneNumber
                        }).ToList(),
                    }
                }).ToList();
            }
        }
    }
}
