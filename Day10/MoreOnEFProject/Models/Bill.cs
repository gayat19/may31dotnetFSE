using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEFProject.Models
{
    public class Bill
    {
        [Key]
        public int BillNumber { get; set; }
        public DateTime BillDate { get; set; }
        public float Amount { get; set; }

    }
}
