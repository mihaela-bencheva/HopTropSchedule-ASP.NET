using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class DanceGroupFolkDance : InfoModel
    {
        public string DanceGroupId { get; set; }
        public DanceGroup DanceGroup { get; set; }
        public string FolkDanceId { get; set; }
        public FolkDance FolkDance { get; set; }

    }
}
