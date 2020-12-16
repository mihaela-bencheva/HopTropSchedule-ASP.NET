using Data.DataConnection.Seed;
using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.DataConnection
{
    public class ScheduleDbContext: DbContext
    {
        public DbSet<DanceCloth> DanceCloths { get; set; }
        public DbSet<DanceGroup> DanceGroups { get; set; }
        public DbSet<DanceSong> DanceSongs { get; set; }
        public DbSet<FolkDance> FolkDances { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PracticeSchedule> PracticeSchedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DanceGroupFolkDance> DanceGroupFolkDances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=.;Database=HopTropSchedule;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData seedData = new SeedData();
            base.OnModelCreating(seedData.Seed(modelBuilder));
        }
    }
}
