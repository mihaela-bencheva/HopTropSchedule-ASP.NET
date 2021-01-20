using Microsoft.AspNetCore.Http;
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
        public int UserCount { get; set; }
        public int FolkDances { get; set; }
        public IFormFile Image { get; set; }
    }
}
