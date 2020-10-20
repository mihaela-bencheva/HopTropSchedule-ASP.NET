using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class PracticeSchedule : InfoModel
    {
        public string DayName { get; set; }
        public string PracticeTime { get; set; }
        public string DanceGroupId { get; set; }
        public DanceGroup DanceGroup { get; set; }
    }
}
