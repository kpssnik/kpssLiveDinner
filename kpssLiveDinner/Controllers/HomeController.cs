using kpssLiveDinner.Domain;
using kpssLiveDinner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace kpssLiveDinner.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager) => _dataManager = dataManager;
     
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }  
        public IActionResult Blog()
        {
            return View(_dataManager.BlogItems.GetBlogItems());
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Reservation()
        {
            return View(_dataManager.CustomerReviews.GetCustomerReviews());
        }
        public IActionResult Stuff()
        {
            return View(_dataManager.StuffItems.GetStuffItems());
        }
        public IActionResult Gallery()
        {
            return View(_dataManager.GalleryImages.GetGalleryImages());
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
