using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class User : InfoModel
    {
        [Required]
        [EmailAddress]
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(150)]
        public string Password { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [Phone]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public string DanceGroupId { get; set; }
        public DanceGroup DanceGroup { get; set; }
    }
}
