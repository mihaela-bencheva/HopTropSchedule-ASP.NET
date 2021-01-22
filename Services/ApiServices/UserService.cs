using Data.DataConnection;
using Data.Models.Models;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                    DanceGroupId = groupId,
                    Email = y.Email,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    PhoneNumber = y.PhoneNumber
                })
                    .OrderBy(y => y.FirstName)
                    .ToList();
            };
        }

        public bool UpdateExistingUser(UserDto user)
        {
            var danceGroupID = dbContext.DanceGroups.Where(
                        y => y.DanceGroupName == user.DanceGroupName
                        ).FirstOrDefault().ID;
            var ifExists = dbContext.Users.Where(x =>
                x.Email == user.Email)
                .FirstOrDefault();
            if (ifExists != null)
            {
                ifExists.Email = user.Email;
                ifExists.FirstName = user.FirstName;
                ifExists.LastName = user.LastName;
                ifExists.PhoneNumber = user.PhoneNumber;
                ifExists.DanceGroupId = danceGroupID;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<UserDto> GetAllUsers()
        {
            using (dbContext)
            {
                return dbContext.Users.Select(x => new UserDto
                {
                    DanceGroupId = x.DanceGroupId,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber
                })
                    .OrderBy(x => x.FirstName)
                    .ToList();
            }
        }

        public bool DeleteExistingUser(UserEmailDto user)
        {
            var ifExists = dbContext.Users.Where(x =>
                x.Email == user.Email 
                ).FirstOrDefault();
            if (ifExists != null)
            {
                dbContext.Users.Remove(ifExists);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public UserDto GetUserById(string userId)
        {
            using (dbContext)
            {
                return dbContext.Users.Where(x => x.ID == userId).Select(y => new UserDto
                {
                    DanceGroupId = y.DanceGroupId,
                    Email = y.Email,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    PhoneNumber = y.PhoneNumber
                }).FirstOrDefault();
            }
        }
    }
}
