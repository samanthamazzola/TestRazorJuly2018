using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestRazorJuly2018.Models;

namespace TestRazorJuly2018.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult SearchProducts(string productName) //datatype and var productName
        //later will use productName to search for and connect db
        {
            //db for products
            //create and array of strings
            string[] products = { "Coke", "Water", "Coffee", "Ruffles Chips" };

            string[] results= products.Where(x => x.ToLower().Contains(productName.ToLower())).ToArray();

            ViewBag.SearchResults = results;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
