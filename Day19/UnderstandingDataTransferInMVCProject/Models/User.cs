using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingDataTransferInMVCProject.Models
{
    public class User
    {
        [Required(ErrorMessage ="Employee Id cannot be empty")]
        [Range(1,100,ErrorMessage ="Invalid entry for employee id")]
        public int Username { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
