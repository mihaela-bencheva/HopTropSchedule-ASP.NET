using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class PracticeSchedule : InfoModel
    {
        [StringLength(20)]
        public string DayName { get; set; }
        [StringLength(10)]
        public string PracticeTime { get; set; }
        public string DanceGroupId { get; set; }
        public DanceGroup DanceGroup { get; set; }
    }
}
