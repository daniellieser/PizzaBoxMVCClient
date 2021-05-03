using Microsoft.AspNetCore.Mvc;
using PizzaBoxMVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Controllers
{
  public class OrderController : Controller
  {
    Client client = new Client();
        public IActionResult Index() 
        {
            var order = new Order();
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.Order order)
        {
            System.Diagnostics.Debug.WriteLine("  userid: " + order.UserId);
            System.Diagnostics.Debug.WriteLine(" storeID: " + order.StoreId);
            System.Diagnostics.Debug.WriteLine(" summary: " + order.Summary);
            client.Save(order);
            return View("ThankYou", order);
           
        }

    }
}