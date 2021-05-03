using Microsoft.AspNetCore.Mvc;
using PizzaBoxMVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Controllers
{
  public class ThankYouController : Controller
  {
    Client client = new Client();
       // public IActionResult Index() 
       // {
        //    var order = new Order();
        //    
       //     return View();
       // }
       
        public IActionResult Index()
        {
            Order order = new Order();
            order.Summary = "14 Inch Deep Dish Meat Pizza with Bacon and Sausage";
            order.TimeReceived = System.DateTime.Now;
            order.StoreId = 1;
           // order.UserId = 123;

           // ViewData["Order"] = order;
            return View(order);
        }

    }
}