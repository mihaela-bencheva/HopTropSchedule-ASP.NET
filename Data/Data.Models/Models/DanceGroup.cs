using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class DanceGroup : InfoModel
    {
        [StringLength(20)]
        public string DanceGroupName { get; set; }
        public List<User> Users { get; set; }
        public List<PracticeSchedule> PracticeSchedules { get; set; }
        public List<DanceGroupFolkDance> DanceGroupFolkDances { get; set; }
        public Image Image { get; set; }
    }
}
