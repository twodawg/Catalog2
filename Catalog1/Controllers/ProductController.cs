using System;
using System.Web;
using System.Web.Mvc;
using Catalog1.Models;
using System.Collections.Generic;

namespace Catalog1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string CustomProduct)
        {
            ViewBag.UserName = "Lord User";

            if (String.IsNullOrEmpty(CustomProduct))
            {
                CustomProduct = "";
            }

            ViewBag.Products = new Dictionary<string, Product>()
            {
                {"Widget", new Product("Widget",10,2.50m,"Normal everyday widget")},
                {"SuperWidget", new Product("SuperWidget",20,12.99m,"A better widget")},
                {"MegaWidget", new Product("MegaWidget",25,79.99m,"Mega super better widget")},
                {"iWidget", new Product("iWidget",18,101.99m,"An Apple widget with twice the goodness")},
                {"WidgetKitchen", new Product("WidgetKitchen",4,10.98m,"Get the kitchen widget now")},
                {CustomProduct, new Product(CustomProduct,0,250.00m,"Your custom made widget")},
            };

            ViewBag.CustomProductParam = CustomProduct;

            foreach(Product product in ViewBag.Products.Values)
            {
                product.Price -= Decimal.Round(product.Price * 0.15m, 2);
            }

            return View();

            // First code we tried
            //Decimal[] prices = new Decimal[] 
            //{
            //    1.99m,
            //    3.85m,
            //    2.25m,
            //    170.23m,
            //    5.55m
            //};

            //ViewBag.Prices = prices;
            
            //return View();
        }
    }
}