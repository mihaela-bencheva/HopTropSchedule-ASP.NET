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
    public class DanceService
    {
        private readonly ScheduleDbContext dbContext;

        public DanceService(ScheduleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool CreateNewDance(FolkDanceDto dance)
        {
            var ifExists = dbContext.FolkDances.Where(
                x =>
                    x.FolkDanceName == dance.FolkDanceName &&
                    x.FolkDanceRegion == dance.FolkDanceRegion &&
                    x.FolkDanceSize == dance.FolkDanceSize
            );
            if (ifExists == null)
            {
                dbContext.FolkDances.Add(new FolkDance()
                {
                    FolkDanceName = dance.FolkDanceName,
                    FolkDanceRegion = dance.FolkDanceRegion,
                    FolkDanceSize = dance.FolkDanceSize
                });
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteExistingDance(FolkDanceDto folk)
        {
            var ifExists = dbContext.FolkDances.Where(
                x =>
                    x.FolkDanceName == folk.FolkDanceName &&
                    x.FolkDanceRegion == folk.FolkDanceRegion &&
                    x.FolkDanceSize == folk.FolkDanceSize
                ).FirstOrDefault();
            if (ifExists != null)
            {
                dbContext.FolkDances.Remove(ifExists);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateExistingDance(FolkDanceDto folk)
        {
            var ifExists = dbContext.FolkDances.Where(
                x => x.ID == folk.ID
                ).FirstOrDefault();
            if (ifExists != null)
            {
                ifExists.FolkDanceName = folk.FolkDanceName;
                ifExists.FolkDanceRegion = folk.FolkDanceRegion;
                ifExists.FolkDanceSize = folk.FolkDanceSize;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<FolkDanceDto> GetAllDances()
        {
            using (dbContext)
            {
                return dbContext.FolkDances.Select(x => new FolkDanceDto
                {
                    ID = x.ID,
                    FolkDanceName = x.FolkDanceName,
                    FolkDanceRegion = x.FolkDanceRegion,
                    FolkDanceSize = x.FolkDanceSize
                }).ToList();
            }
        }
    }
}
