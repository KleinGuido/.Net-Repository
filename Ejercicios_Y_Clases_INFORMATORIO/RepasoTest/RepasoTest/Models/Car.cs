using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepasoTest.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [required]
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public DateTime DateCreated { get; set; }
        
    }
}