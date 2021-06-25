using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingDataTransferInMVCProject.Models
{
    public class EmployeeViewModel: Employee
    {
        [Required]
        [Display(Name="Password")]
        public string UserPassword { get; set; }
        [Required]
        [Display(Name="Re-Type Password")]
        [Compare("UserPassword", ErrorMessage ="Password mismatch")]
        public string RetypePassord { get; set; }
        public List<SelectListItem> DeparmentList { get; set; }
    }
}
