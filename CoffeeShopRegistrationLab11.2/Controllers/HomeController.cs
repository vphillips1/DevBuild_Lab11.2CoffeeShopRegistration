using CoffeeShopRegistrationLab11._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopRegistrationLab11._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistrationForm()
        {

            return View();
        }

        [HttpPost]
        public IActionResult RegistrationResponse(string firstname, string lastname, string email, int phonenumber, string password )
        {
            if(password.Length < 8 )

            {

                return Content("Sorry, password must be at least 8 characters");
            }
            ViewData["First Name"] = firstname;
            ViewData["Last Name"] = lastname;
            ViewData["Email"] = email;
            ViewData["Phone Number"] = phonenumber;
            ViewData["Password"] = password;
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
