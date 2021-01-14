using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models.My
{
    public class CalculatePriceUtil
    {

        public static decimal getTotalProductPrice(List<Product> productList)
        {
            decimal totalPrice = decimal.Zero;

            foreach (Product product in productList)
            {
                totalPrice += product.getPrice();
            }

            return totalPrice;
        }

        public static decimal getTotalPackagePrice(List<Package> packageList)
        {
            decimal totalPrice = decimal.Zero;

            foreach (Package package in packageList)
            {
                totalPrice += package.getPrice();
            }

            return totalPrice;
        }

    }
}
