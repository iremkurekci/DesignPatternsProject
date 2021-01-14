using DesignPatternsProject.Abstarcts;
using DesignPatternsProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models
{
    public class Basket : Base
    {
        public List<IPriceable> priceableList { get; set; }
        public decimal minPrice { get; set; }
        public Basket(string name)
        {
            this.name = name;
            this.piece = piece;
            this.unitPrice = unitPrice;
            this.minPrice = 300;
            this.priceableList = new List<IPriceable>();
        }

        public decimal GetTotalPrice()
        {
                decimal totalPrice = decimal.Zero;
                foreach (IPriceable ipriceable in priceableList)
                {
                    totalPrice += ipriceable.getPrice();
                }
                return totalPrice;
        }

        public bool isLess(decimal totalPrice)
        {
            bool conclusion = false;
            if(totalPrice < minPrice)
            {
                conclusion = true;
            }
            return conclusion;
        }
    }
}
