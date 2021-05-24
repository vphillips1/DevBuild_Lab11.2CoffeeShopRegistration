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
    public class AdminController : Controller
    {
       static MySqlConnection db = new MySqlConnection("Server=localhost;Database=Coffeeshop;Uid=root;Password=abc727");
        public IActionResult Index()
        {

            List<Product> prod = db.GetAll<Product>().ToList();
          
            return View(prod);
        
        }

        public IActionResult Detail(int id)
        {

            Product prod = db.Get<Product>(id);
            return View(prod);
        }

        public IActionResult AdminForm(AdminLogin admin)
        {
            
            return View(admin);

            
        }

        //public IActionResult EditForm (int id)

        //{
        //    Product prod = db.Get<Product>(id);
        //    return View(prod);
        //}

        //[HttpPost]
        //public IActionResult Edit (Product prod)
        //{

        //    db.Update(prod);

        //    return RedirectToAction("Index");
        //}


        //public IActionResult DeleteProduct()
        //{

        //    return View();
        //}

        //public IActionResult Delete(int id)
        //{
        //   Product prod = db.Get<Product>(id);

        //   db.Delete(prod);

        //    return RedirectToAction("Index");
        //}
          

        //public IActionResult AddForm()
        //{

        //    return View();
        //}


        //[HttpPost]
        //public IActionResult Add(Product prod)
        //{

        //    db.Insert(prod);

        //    return RedirectToAction("Index");
        //}


               

    }




        



}
