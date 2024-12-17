using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Portfolio
    {
        [Key]
        public int PortfoiloID { get; set; }
        public string Name { get; set; }
        public string ImageUrl1 { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string Platform { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public int value { get; set; }
    }
}
