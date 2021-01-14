using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Models.My
{
    public class CalculatePieceUtil
    {
        public static int getTotalPieceProduct(List<Product> productList)
        {
            int totalPiece = productList.Count();

            return totalPiece;
        }
        public static int getTotalPiecePackage(List<Package> packageList)
        {
            int totalPiece = 0;
            foreach (Package package in packageList)
            {
                totalPiece = package.getPiece();
            }

            return totalPiece;
        }
    }
}
