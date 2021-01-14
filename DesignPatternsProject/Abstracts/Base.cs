using DesignPatternsProject.Interfaces;
using DesignPatternsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Abstarcts
{
    public abstract class Base 
    {
        public string name { get; set; }
        public int piece { get; set; } //adet
        public decimal unitPrice { get; set; } //birim fiyat
        public int stock { get; set; }
        public virtual decimal getPrice() //virtual is necessary to overriding in other classes
        {
            return piece * unitPrice;
        }

        public virtual int getPiece()
        {
            return piece;
        }
        public virtual int getStock()
        {
            return stock;
        }

    }
}
