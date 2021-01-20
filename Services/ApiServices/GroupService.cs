using Data.DataConnection;
using Data.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Services.DTOModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services.ApiServices
{
    public class GroupService
    {
        private readonly ScheduleDbContext dbContext;
        public GroupService(ScheduleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> CreateNewDanceGroup(DanceGroupDto danceGroup, string rootPath)
        {
            var ifExists = dbContext.DanceGroups.Where(
                x =>
                    x.DanceGroupName == danceGroup.DanceGroupName
                ).FirstOrDefault();
            if (ifExists == null)
            {
                Image image = new Image();
                if (danceGroup.Image != null)
                {
                    string imagePath = await UploadImage(rootPath, danceGroup.Image);
                    image = new Image() { ImageUrl = imagePath };
                }
               
                dbContext.DanceGroups.Add(new DanceGroup()
                {
                    DanceGroupName = danceGroup.DanceGroupName,
                    Image =  image
                });
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public DanceGroupDto FindGroupByName(string groupName)
        {
            using(dbContext)
            {
                return dbContext.DanceGroups.Where(x => x.DanceGroupName == groupName).Select(y => new DanceGroupDto
                {
                    ID = y.ID,
                    DanceGroupName = y.DanceGroupName
                }).FirstOrDefault();
            };
        }
        public bool DeleteExistingDanceGroup(DanceGroupDto danceGroup)
        {
            var ifExists = dbContext.DanceGroups.Where(
                x =>
                    x.DanceGroupName == danceGroup.DanceGroupName
                ).FirstOrDefault();
            if (ifExists != null)
            {
                dbContext.DanceGroups.Remove(ifExists);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateExistingDanceGroup(DanceGroupDto danceGroup)
        {
            var ifExists = dbContext.DanceGroups.Where(
                x =>
                    x.ID == danceGroup.ID
                ).FirstOrDefault();
            if (ifExists != null)
            {
                ifExists.DanceGroupName = danceGroup.DanceGroupName;
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DanceGroupDto> GetGroupDetails(string groupName)
        {
            return dbContext.DanceGroupFolkDances
                .Include(x => x.FolkDance)
                .Include(x => x.DanceGroup)
                .Where(x => x.DanceGroup.DanceGroupName == groupName)
                .GroupBy(x => new { x.DanceGroup.ID, x.DanceGroup.DanceGroupName})
                .Select(x => new DanceGroupDto()
                {
                    ID = x.Key.ID,
                    DanceGroupName = x.Key.DanceGroupName,
                    FolkDances = x.Count(),
                })
                .ToList();
        }

        public List<DanceGroupDto> GetAllGroups()
        {
            using (dbContext)
            {
                var groups = dbContext.DanceGroups.Select(x => new DanceGroupDto
                {
                    DanceGroupName = x.DanceGroupName,
                    Image = GetFormFile(x.Image)
                }).ToList();
                return groups;
            }
        }

        private IFormFile GetFormFile(Image image)
        {

            //using (var stream = System.IO.File.OpenRead($"{image.ImageUrl}"))
            //{
            //    return new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
            //}
            return null;
        }

        private async Task<string> UploadImage(string rootPath, IFormFile form)
        {
            string image = form.FileName;
            string path = Path.Combine(rootPath, "Images\\Groups", image);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await form.CopyToAsync(stream);
            }
            byte[] array;
            using (var memoryStream = new MemoryStream())
            {
                await form.CopyToAsync(memoryStream);
                array = memoryStream.ToArray();
            }
            return string.Format($"{path}\\{ image}");
        }
    }
}
