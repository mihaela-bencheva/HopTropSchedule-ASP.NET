using Data.DataConnection;
using Services;
using Services.ApiServices;
using System;

namespace Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentityService identityService = new IdentityService(new ScheduleDbContext());
            identityService.RegisterUser(new Services.DTOModels.UserDto()
            {
                Email = "mihaela@mail.com",
                Password = "mm+15",
                CheckPassword = "mm+15"
            });
            identityService.LogInUser(new Services.DTOModels.UserDto()
            {
                Email = "mihaela@mail.com",
                Password = "mm+15",
            });
            ScheduleService scheduleService = new ScheduleService(new ScheduleDbContext());
            var schedules = scheduleService.GetAll();
            foreach (var item in schedules)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
