using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewTask.Models;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Greetings() => View();

        public IActionResult ProductInfo() => View();

        public IActionResult SuperMarkets()
        {
            ViewBag.Supermarkets = new List<string> { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };
            return View();
        }

        public IActionResult ShoppingList()
        {
            var list = new Dictionary<string, int>
            {
                { "Milk", 2 },
                { "Bread", 2 },
                { "Cake", 1 },
                { "Ice Cream", 5 },
                { "Cola", 10 }
            };
            return View(list);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            ViewBag.Supermarkets = new List<string> { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };
            ViewBag.Products = new List<string> { "Bread", "Milk", "Cheese", "Sausage" };
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(string fullname, string address)
        {
            ViewBag.Message = $"Your products will be shipped at: {address}. Bon appetite, {fullname}!";
            ViewBag.Supermarkets = new List<string> { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };
            ViewBag.Products = new List<string> { "Bread", "Milk", "Cheese", "Sausage" };
            return View();
        }
    }
}