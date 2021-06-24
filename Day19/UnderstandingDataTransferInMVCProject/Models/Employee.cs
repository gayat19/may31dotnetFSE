using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingDataTransferInMVCProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        public int Department_Id { get; set; }
        public string Password { get; set; }
        [ForeignKey("Department_Id")]
        public Department Department { get; set; }
    }
}
