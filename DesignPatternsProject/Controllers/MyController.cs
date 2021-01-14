using DesignPatternsProject.Interfaces;
using DesignPatternsProject.Models;
using DesignPatternsProject.Models.My;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsProject.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Basket()
        {
            Product tomato = new Product("Tomato", 15, 3.21m);
            Product potato = new Product("Potato", 8, 1.5m);
            Product carrot = new Product("Carrot", 6, 4.2m);
            Product onion = new Product("Onion", 7, 1.3m);

            List<Product> isstockList = new List<Product>();

            List<Product> products1 = new List<Product>();
            products1.Add(tomato);
            products1.Add(potato);
            products1.Add(carrot);
            products1.Add(onion);

            Package vegetablePackage = new Package("Vegetables Package");

            foreach (Product item in products1)
            {
                if (item.StockControl() >= 0)
                {
                    vegetablePackage.productList.Add(item);
                }
                else
                {
                    isstockList.Add(item);
                }
            }

            Product milk = new Product("Milk", 2, 2.6m);
            Product juice = new Product("Juice", 3, 1.7m);
            Product water = new Product("Water", 1, 0.54m);

            List<Product> products2 = new List<Product>();
            products2.Add(milk);
            products2.Add(juice);
            products2.Add(water);

            Package drinkPackage = new Package("Drinks Package");

            foreach (Product item in products2)
            {
                if (item.StockControl() >=0)
                {
                    drinkPackage.productList.Add(item);
                }
                else
                {
                    isstockList.Add(item);
                }
            }

            Product ball = new Product("Ball", 1, 12.8m);
            Product pencil = new Product("Pencil", 2, 2.18m);

            Box box1 = new Box("Box 1");
            if (ball.StockControl() >= 0)
            {
                box1.productList.Add(ball);
            }
            else
            {
                isstockList.Add(ball);
            }
            box1.packageList.Add(vegetablePackage);

            Box box2 = new Box("Box 2");
            if (pencil.StockControl() >= 0)
            {
                box2.productList.Add(pencil);
            }
            else
            {
                isstockList.Add(pencil);
            }
            box2.packageList.Add(drinkPackage);

            Basket basket = new Basket("My Basket");
            basket.priceableList.Add(vegetablePackage);
            basket.priceableList.Add(drinkPackage);

            if (ball.StockControl() >= 0)
            {
                basket.priceableList.Add(ball);
            }
            if (pencil.StockControl() >= 0)
            {
                basket.priceableList.Add(pencil);
            }

            basket.priceableList.Add(box1);
            basket.priceableList.Add(box2);

            decimal totalPrice = basket.GetTotalPrice();

            ViewBag.totalPrice = totalPrice;

            if (basket.isLess(totalPrice) == true)
            {
                ViewBag.warning = "Your basket price must be more than min price. Please add another " + (basket.minPrice - totalPrice) + " $ of items.";
            }
            else
            {
                ViewBag.warning = "Your basket price is valid. Thanks for your shopping..";
            }
            for (int i = 0; i <= isstockList.Count() - 1; i++)
            {
                ViewBag.isstock += "There is not enough " + isstockList[i].name + ". Current " + isstockList[i].name + " stock is "
                    + isstockList[i].stock + " but your order is " + isstockList[i].piece + ".";
            }

            List<ProductViewModel> myList = new List<ProductViewModel>();

            for (int i = 0; i <= basket.priceableList.Count() - 1; i++)
            {

                var data = new ProductViewModel();

                data.Name = basket.priceableList[i].name;
                data.Piece = basket.priceableList[i].getPiece();
                data.UnitPrice = basket.priceableList[i].getPrice();
                data.stock = basket.priceableList[i].getStock();
                

                myList.Add(data);

            }
            ViewBag.data = myList;

            return View(myList);
        }

    }
}
