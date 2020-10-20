using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class FolkDanceSong : InfoModel
    {
        public string FolkDanceId { get; set; }
        public FolkDance FolkDance { get; set; }
        public string DanceSongId { get; set; }
        public DanceSong DanceSong { get; set; }
    }
}
