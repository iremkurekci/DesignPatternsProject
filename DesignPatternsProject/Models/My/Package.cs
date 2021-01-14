using DesignPatternsProject.Abstarcts;
using DesignPatternsProject.Interfaces;
using DesignPatternsProject.Models.My;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models
{
    public class Package : Base, IPriceable //PAKET
    {
        public CalculatePriceUtil calculate { get; set; }

        public List<Product> productList { get; set; }
        public Package(string name)
        {
            this.name = name;

            this.productList = new List<Product>();

        }

        public override decimal getPrice() //overriding
        {
            return CalculatePriceUtil.getTotalProductPrice(productList);
        }

        public override int getPiece() //overriding
        {
            return CalculatePieceUtil.getTotalPieceProduct(productList);
        }
        public override int getStock() //overriding
        {
            return 10;
        }
    }

}
