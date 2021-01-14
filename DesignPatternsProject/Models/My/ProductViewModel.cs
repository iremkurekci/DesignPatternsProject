using DesignPatternsProject.Models.My;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int Piece { get; set; }
        public decimal UnitPrice { get; set; }
        public int stock { get; set; }
        public Product product { get; set; }
        public Package package { get; set; }
        public Box box { get; set; }
        
        
    }
}
