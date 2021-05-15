using CoffeeShopRegistrationLab11._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
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
      
        public IActionResult RegistrationResponse(AddUser user )
        {
          
            if(user.Password != user.PasswordConfirmation)
            {

                return View("PasswordNotConfirmed");
            }
            else if(user.Email != user.EmailConfirmation)
            {

                return View("EmailNotConfirmed");
            }

            Regex rx = new Regex(@"[0-9]+");

            string goback = "click 'Back' to return to the registration form.";

            if (rx.IsMatch(user.FirstName) || rx.IsMatch(user.LastName))
            {

                return Content($"Your name cannot contain any numbers. {goback}");
            }

            return View(user);
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
