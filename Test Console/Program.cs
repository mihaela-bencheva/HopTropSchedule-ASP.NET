using Data.DataConnection;
using Services;
using Services.ApiServices;
using Services.DTOModels;
using System;

namespace Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentityService identityService = new IdentityService(new ScheduleDbContext());
            identityService.RegisterUser(new Services.DTOModels.RegisterDto()
            {
                Email = "mihaela@mail.eu",
                Password = "mm+15",
                CheckPassword = "mm+15"
            });
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
            GroupService group = new GroupService(new ScheduleDbContext());
            ScheduleService scheduleService = new ScheduleService(new ScheduleDbContext());

            ScheduleDto schedule = new ScheduleDto();
            schedule.DayName = "Friday";
            schedule.PracticeTime = "19:30";
            schedule.DanceGroupId = group.FindGroupByName("Напреднали").ID;
            scheduleService.CreateNewSchedule(schedule);
        }
    }
}
