﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Interfaces
{
    interface IInfo
    {
        [Key]
        [StringLength(8)]
        string ID { get; set; }
    }
}
