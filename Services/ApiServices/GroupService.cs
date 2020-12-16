using Data.DataConnection;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
