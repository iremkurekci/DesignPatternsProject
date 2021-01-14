using DesignPatternsProject.Abstarcts;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Interfaces
{
    public interface IPriceable //FİYATLANABİLİR
    {
        public string name { get; set; }
        public int piece { get; set; } 
        public decimal unitPrice { get; set; } 

        public decimal getPrice();
        public int getPiece();
        public int getStock();
       
    }
}
