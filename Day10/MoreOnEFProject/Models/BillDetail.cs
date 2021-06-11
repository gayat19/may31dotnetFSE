using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEFProject.Models
{
    public class BillDetail
    {
        public int BillNumber { get; set; }
        
        public string ItemId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("BillNumber")]
        public Bill Bill { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
