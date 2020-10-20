using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class DanceCloth : InfoModel
    {
        public string ClothType { get; set; }
        public string ShoesType { get; set; }
        public FolkDance FolkDance { get; set; }
    }
}
