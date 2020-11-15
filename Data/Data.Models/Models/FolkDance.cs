using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class FolkDance : InfoModel
    {
        [StringLength(30)]
        public string FolkDanceName { get; set; }
        [StringLength(10)]
        public string FolkDanceSize { get; set; }
        [StringLength(30)]
        public string FolkDanceRegion { get; set; }
        public List<DanceGroupFolkDance> DanceGroupFolkDances { get; set; }
        public string DanceClothId { get; set; }
        public DanceCloth DanceCloth { get; set; }
        public List<FolkDanceSong> FolkDanceSongs { get; set; }
    }
}
