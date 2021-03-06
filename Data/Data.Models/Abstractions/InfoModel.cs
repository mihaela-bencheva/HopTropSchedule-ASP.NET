﻿using Data.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Abstractions
{
    public abstract class InfoModel : IInfo
    {
        public InfoModel()
        {
            ID = Guid.NewGuid().ToString();
        }
        public string ID { get; set; }
    }
}
