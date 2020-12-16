using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOModels
{
    public class DanceGroupDto
    {
        public string ID { get; set; }
        public string DanceGroupName { get; set; }
        public List<UserDto> Users { get; set; }
    }
}
