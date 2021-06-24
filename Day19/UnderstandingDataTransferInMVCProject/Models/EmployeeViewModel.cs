using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingDataTransferInMVCProject.Models
{
    public class EmployeeViewModel: Employee
    {
        public string RetypePassord { get; set; }
        public List<SelectListItem> DeparmentList { get; set; }
    }
}
