﻿using Data.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOModels
{
    public class ScheduleDto
    {
        public string ScheduleID { get; set; }
        public string DayName { get; set; }
        public string PracticeTime { get; set; }
        public string DanceGroupId { get; set; }
        public string DanceGroupName { get; set; }
        public override string ToString()
        {
            return DayName + " " + PracticeTime + " " + DanceGroupId;
        }
    }
}
