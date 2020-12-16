using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataConnection.Seed
{
    public class SeedData
    {
        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            List<DanceGroup> danceGroups = new List<DanceGroup>()
            {
                new DanceGroup()
                {
                    DanceGroupName = "Начинаещи"
                },
                new DanceGroup()
                {
                    DanceGroupName = "Напреднали"
                },
                
                new DanceGroup()
                {
                    DanceGroupName = "Майстори"
                },
            };
            List<User> users = new List<User>()
            {
                new User()
                {
                    Email = "abc@abc.bg",
                    Password = "123a+",
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    PhoneNumber = "0123456789",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "goshka@abv.bg",
                    Password = "123g+",
                    FirstName = "Ginka",
                    LastName = "Goshkova",
                    PhoneNumber = "0123457789",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[1]
                },
                new User()
                {
                    Email = "dragana@abc.bg",
                    Password = "123d+",
                    FirstName = "Dragana",
                    LastName = "Draganova",
                    PhoneNumber = "0124456789",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "abc@abc.bg",
                    Password = "123a+",
                    FirstName = "Desa",
                    LastName = "Ivanova",
                    PhoneNumber = "0123456789",
                    DanceGroupId = danceGroups[2].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "goshka@abv.bg",
                    Password = "123g+",
                    FirstName = "Gena",
                    LastName = "Genova",
                    PhoneNumber = "0123457789",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[1]
                },
                new User()
                {
                    Email = "dragana@abc.bg",
                    Password = "123d+",
                    FirstName = "Pepa",
                    LastName = "Draginova",
                    PhoneNumber = "0124456789",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "abc@abc.bg",
                    Password = "123a+",
                    FirstName = "Petko",
                    LastName = "Ivanovic",
                    PhoneNumber = "0123456789",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "goshka@abv.bg",
                    Password = "123g+",
                    FirstName = "Reni",
                    LastName = "Renova",
                    PhoneNumber = "0123457789",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[1]
                },
                new User()
                {
                    Email = "dragana@abc.bg",
                    Password = "123d+",
                    FirstName = "Andreya",
                    LastName = "Draganova",
                    PhoneNumber = "0124456789",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "abc@abc.bg",
                    Password = "123a+",
                    FirstName = "Dimitar",
                    LastName = "Penkov",
                    PhoneNumber = "0123453789",
                    DanceGroupId = danceGroups[2].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "goshka@abv.bg",
                    Password = "123g+",
                    FirstName = "Petya",
                    LastName = "Peteva",
                    PhoneNumber = "0123459789",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[1]
                },
                new User()
                {
                    Email = "dragana@abc.bg",
                    Password = "123d+",
                    FirstName = "Ivana",
                    LastName = "Sokolova",
                    PhoneNumber = "0124456949",
                    DanceGroupId = danceGroups[2].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "abc@abc.bg",
                    Password = "123a+",
                    FirstName = "Ivanitsa",
                    LastName = "Ivanova",
                    PhoneNumber = "01234556789",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[0]
                },
                new User()
                {
                    Email = "goshka@abv.bg",
                    Password = "123g+",
                    FirstName = "Viki",
                    LastName = "Viktorova",
                    PhoneNumber = "0123432789",
                    DanceGroupId = danceGroups[2].ID,
                    //DanceGroup = danceGroups[1]
                },
                new User()
                {
                    Email = "dragana@abc.bg",
                    Password = "123d+",
                    FirstName = "Petkana",
                    LastName = "Draganova",
                    PhoneNumber = "0124456789",
                    DanceGroupId = danceGroups[2].ID,
                    //DanceGroup = danceGroups[0]
                }
            };
            List<FolkDance> folkDances = new List<FolkDance>()
            {
                new FolkDance()
                {
                    FolkDanceName = "Svornato",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Chichovo",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Pravo",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Lyavata",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Pandalaj",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Ginka",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Dunavsko",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Pravo Trakiisko",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Sborenka",
                    FolkDanceSize = "2/4",
                },
                new FolkDance()
                {
                    FolkDanceName = "Graovsko",
                    FolkDanceSize = "2/4",
                },
            };
            List<PracticeSchedule> practiceSchedules = new List<PracticeSchedule>()
            {
                new PracticeSchedule()
                {
                    DayName = "Ponedelnik",
                    PracticeTime = "18:30",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new PracticeSchedule()
                {
                    DayName = "Ponedelnik",
                    PracticeTime = "19:40",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[1]
                },
                new PracticeSchedule()
                {
                    DayName = "Ponedelnik",
                    PracticeTime = "20:50",
                    DanceGroupId = danceGroups[2].ID,
                    //DanceGroup = danceGroups[2]
                },
                new PracticeSchedule()
                {
                    DayName = "Vtornik",
                    PracticeTime = "17:30",
                    DanceGroupId = danceGroups[0].ID,
                    //DanceGroup = danceGroups[0]
                },
                new PracticeSchedule()
                {
                    DayName = "Vtornik",
                    PracticeTime = "18:40",
                    DanceGroupId = danceGroups[1].ID,
                    //DanceGroup = danceGroups[1]
                },
            };
            List<DanceCloth> danceCloths = new List<DanceCloth>()
            {
                new DanceCloth()
                {
                    ClothType = "Женска носия",
                    ShoesType = "Скарпини"
                },
                new DanceCloth()
                {
                    ClothType = "Мъжка носия",
                    ShoesType = "Скарпини"
                },
                new DanceCloth()
                {
                    ClothType = "Женска носия",
                    ShoesType = "Цървули"
                },
                new DanceCloth()
                {
                    ClothType = "Мъжка носия",
                    ShoesType = "Цървули"
                }
            };
            List<DanceSong> danceSongs = new List<DanceSong>()
            {
                new DanceSong()
                {
                    SongName = "Pesen1",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen2",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen3",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen4",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen5",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen6",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen7",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen8",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen9",
                    SongUrl = "123"
                },
                new DanceSong()
                {
                    SongName = "Pesen10",
                    SongUrl = "123"
                }
            };
            modelBuilder.Entity<DanceGroup>().HasData(danceGroups);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<FolkDance>().HasData(folkDances);
            modelBuilder.Entity<PracticeSchedule>().HasData(practiceSchedules);
            modelBuilder.Entity<DanceCloth>().HasData(danceCloths);
            modelBuilder.Entity<DanceSong>().HasData(danceSongs);
            return modelBuilder;
        }
    }
}
