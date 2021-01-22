using Data.DataConnection;
using Services;
using Services.ApiServices;
using Services.DTOModels;
using System;
using System.Collections.Generic;

namespace Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //IdentityService identityService = new IdentityService(new ScheduleDbContext());
            //identityService.RegisterUser(new Services.DTOModels.RegisterDto()
            //{
            //    Email = "mihaela666@mail.de",
            //    Password = "mm+15",
            //    CheckPassword = "mm+15",
            //    FirstName = "Mihaela",
            //    LastName = "Bencheva"
            //});
            //identityService.LogInUser(new Services.DTOModels.UserDto()
            //{
            //    Email = "mihaela@mail.com",
            //    Password = "mm+15",
            //});
            //ScheduleService scheduleService = new ScheduleService(new ScheduleDbContext());
            //var schedules = scheduleService.GetAll();
            //foreach (var item in schedules)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine();
            //ScheduleService scheduleService1 = new ScheduleService(new ScheduleDbContext());
            //var schedulesByDay = scheduleService1.GetSchedulesByDayName("Ponedelnik");
            //foreach (var item in schedulesByDay)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine();
            //UserService userService = new UserService(new ScheduleDbContext());
            //GroupService groupService = new GroupService(new ScheduleDbContext());
            //var group = groupService.FindGroupByName("Naprednali");
            //var users = userService.GetAllUsersByGroupId(group.ID);
            //foreach (var item in users)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine();
            //ScheduleService scheduleService2 = new ScheduleService(new ScheduleDbContext());
            //var schedulesByGroupId = scheduleService2.GetScheduleByDanceGroupId(group.ID);
            //foreach (var item in schedulesByGroupId)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //ScheduleService scheduleService = new ScheduleService(new ScheduleDbContext());

            //ScheduleDto schedule = new ScheduleDto();
            //schedule.ScheduleID = "4087d118-d268-48eb-bd16-5e4f4c4652df";
            //schedule.DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df";
            //schedule.DayName = "Friday";
            //schedule.PracticeTime = "18:20";
            //scheduleService.UpdateExistingSchedule(schedule);
            //GroupService groupService = new GroupService(new ScheduleDbContext());
            //DanceGroupDto danceGroup = new DanceGroupDto();
            //danceGroup.ID = "e0de92fa-845e-4bf9-bb7e-46172df21f75";
            //danceGroup.DanceGroupName = "Средно напреднали";
            //groupService.UpdateExistingDanceGroup(danceGroup);
            GroupService groupService = new GroupService(new ScheduleDbContext());
            DanceGroupDto list = groupService.GetGroupDetails("Майстори");
            Console.WriteLine(list.FolkDances);
            //UserService userService = new UserService(new ScheduleDbContext());
            //UserDto user = new UserDto();
            //user.Email = "mihaela666@mail.de";
            //user.Password = "mm+15";
            //user.FirstName = "Mihaela";
            //user.PhoneNumber = "0980908074";
            //user.DanceGroupName = "Майстори";
            //userService.UpdateExistingUser(user);
        }
    }
}
