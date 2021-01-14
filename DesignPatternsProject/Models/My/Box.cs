using DesignPatternsProject.Abstarcts;
using DesignPatternsProject.Interfaces;
using DesignPatternsProject.Models.My;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models
{
    public class Box : Base, IPriceable
    {
        public List<Package> packageList;
        public List<Product> productList;
        public CalculatePriceUtil calculate { get; set; }
        public Package package { get; set; }
        public Box(string name)
        {
            this.name = name;
            this.productList = new List<Product>();
            this.packageList = new List<Package>();
        }

        public override decimal getPrice() //overriding
        {
            decimal totalProductPrice = CalculatePriceUtil.getTotalProductPrice(productList);
            decimal totalPackagePrice = CalculatePriceUtil.getTotalPackagePrice(packageList);
            decimal totalPrice = totalProductPrice + totalPackagePrice;
            return totalPrice;
        }

        public override int getPiece() //overriding
        {
            int totalProductPiece = CalculatePieceUtil.getTotalPieceProduct(productList);
            int totalPackagePiece = CalculatePieceUtil.getTotalPiecePackage(packageList);
            int TotalPiece = totalProductPiece + totalPackagePiece;
            return TotalPiece;
        }
        public override int getStock() //overriding
        {
            return 10;
        }
    }
}
