using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class DanceSong : InfoModel
    {
        [StringLength(50)]
        public string SongName { get; set; }
        public string SongUrl { get; set; }
        public List<FolkDanceSong> FolkDanceSongs { get; set; }
    }
}
