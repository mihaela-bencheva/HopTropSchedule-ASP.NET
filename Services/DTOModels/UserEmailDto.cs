using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.DTOModels
{
    public class UserEmailDto
    {
        [Required]
        public string Email { get; set; }
    }
}
