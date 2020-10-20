using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class FolkDance : InfoModel
    {
        public string FolkDanceName { get; set; }
        public string FolkDanceSize { get; set; }
        public string FolkDanceRegion { get; set; }
        public List<DanceGroupFolkDance> DanceGroupFolkDances { get; set; }
        public string DanceClothId { get; set; }
        public DanceCloth DanceCloth { get; set; }
        public List<FolkDanceSong> FolkDanceSongs { get; set; }
    }
}
