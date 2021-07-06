using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeAKSApp.Models
{
  
    public class Weather
    {
        public DateTime Date { get; set; }
        public float TemperatureC { get; set; }
        public float TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
