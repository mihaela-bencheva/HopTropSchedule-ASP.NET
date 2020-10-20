using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class DanceGroup : InfoModel
    {
        public string DanceGroupName { get; set; }
        public List<User> Users { get; set; }
        public List<PracticeSchedule> PracticeSchedules { get; set; }
        public List<DanceGroupFolkDance> DanceGroupFolkDances { get; set; }
        public List<Image> Images { get; set; }
    }
}
