using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class DanceCloth : InfoModel
    {
        [StringLength(30)]
        public string ClothType { get; set; }
        [StringLength(30)]
        public string ShoesType { get; set; }
        public FolkDance FolkDance { get; set; }
    }
}
