using Data.DataConnection;
using Data.Models.Models;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.ApiServices
{
    public class UserService
    {
        private readonly ScheduleDbContext dbContext;
        public UserService(ScheduleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<UserDto> GetAllUsersByGroupId(string groupId)
        {
            using (dbContext)
            {
                return dbContext.Users.Where(x => x.DanceGroupId == groupId).Select(y => new UserDto
                {
                    Email = y.Email,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    PhoneNumber = y.PhoneNumber
                })
                    .OrderBy(y => y.FirstName)
                    .ToList();
            };
        }
    }
}
