using DesignPatternsProject.Abstarcts;
using DesignPatternsProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models
{
    public class Product : Base, IPriceable //ÜRÜN
    {
        public Product(string name, int piece, decimal unitPrice)
        {
            this.name = name;
            this.piece = piece;
            this.unitPrice = unitPrice;
            this.stock = 10;
        }

        public int StockControl()
        {
            if (piece <= stock)
            {
                stock -= piece;
                return stock;
            }

            else 
            {
                return -1;
            }
        }
        public override int getStock()
        {
            return stock;
        }
    }
}
