using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class Image : InfoModel
    {
        public string ImageUrl { get; set; }
        public string DanceGroupId { get; set; }
        public DanceGroup DanceGroup { get; set; }
    }
}
