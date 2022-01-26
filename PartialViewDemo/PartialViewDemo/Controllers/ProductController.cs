using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewDemo.Models;
namespace PartialViewDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> productList = new List<Product>
            {
                new Product{ProductID=1,ProductName="Keyboard",ProductPhoto="~/Products/Keyboard.jpeg"},
                new Product{ProductID=2,ProductName="Monitor",ProductPhoto="~/Products/monitor.jpg"},
                new Product{ProductID=3,ProductName="Mouse",ProductPhoto="~/Products/mouse.jpeg"}
            };

            return View(productList);
        }
    }
}