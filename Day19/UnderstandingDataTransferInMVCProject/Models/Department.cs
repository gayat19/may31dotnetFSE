﻿using System.Collections.Generic;

namespace UnderstandingDataTransferInMVCProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}