using CoffeeShopRegistrationLab11._2.Models;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopRegistrationLab11._2.Controllers
{
    public class ProductController : Controller
    {

        MySqlConnection db = new MySqlConnection("Server=localhost;Database=Coffeeshop;Uid=root;Password=abc727");
        public IActionResult Index()
        {

            List<Product> products = db.GetAll<Product>().ToList();
            return View(products);
        }

        public IActionResult Detail(int id)
        {

            Product products = db.Get<Product>(id);
            return View(products);
        }


    }
}
