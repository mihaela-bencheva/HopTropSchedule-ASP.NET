using Data.DataConnection;
using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Services.ApiServices
{
    public class GroupService
    {
        private readonly ScheduleDbContext dbContext;
        public GroupService(ScheduleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateNewDanceGroup(DanceGroupDto danceGroup)
        {
            var ifExists = dbContext.DanceGroups.Where(
                x =>
                    x.DanceGroupName == danceGroup.DanceGroupName
                ).FirstOrDefault();
            if (ifExists == null)
            {
                dbContext.DanceGroups.Add(new DanceGroup()
                {
                    DanceGroupName = danceGroup.DanceGroupName
                });
                dbContext.SaveChanges();
            }
        }
        public DanceGroupDto FindGroupByName(string groupName)
        {
            using(dbContext)
            {
                return dbContext.DanceGroups.Where(x => x.DanceGroupName == groupName).Select(y => new DanceGroupDto
                {
                    ID = y.ID,
                    DanceGroupName = y.DanceGroupName,
                }).FirstOrDefault();
            };
        }
        public void DeleteExistingDanceGroup(DanceGroupDto danceGroup)
        {
            var ifExists = dbContext.DanceGroups.Where(
                x =>
                    x.DanceGroupName == danceGroup.DanceGroupName
                ).FirstOrDefault();
            if (ifExists != null)
            {
                dbContext.DanceGroups.Remove(ifExists);
                dbContext.SaveChanges();
            }
        }

        public void UpdateExistingDanceGroup(DanceGroupDto danceGroup)
        {
            var ifExists = dbContext.DanceGroups.Where(
                x =>
                    x.ID == danceGroup.ID
                ).FirstOrDefault();
            if (ifExists != null)
            {
                ifExists.DanceGroupName = danceGroup.DanceGroupName;
                dbContext.SaveChanges();
            }
        }

        public List<DanceGroupDto> GetGroupsDetails()
        {
            using (dbContext)
            {
                return dbContext.DanceGroups
                    .Include(x => x.Users)
                    .ToList()
                    .GroupBy(x => new { x.ID, x.DanceGroupName })
                    .Select(x => new DanceGroupDto()
                    {
                        ID = x.Key.ID,
                        DanceGroupName = x.Key.DanceGroupName,
                        UserCount = x.Count()
                    })
                    .OrderBy(x => x.DanceGroupName)
                    .ToList();
            }
        }
    }
}
