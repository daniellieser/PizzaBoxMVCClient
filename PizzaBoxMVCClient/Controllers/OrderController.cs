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
            if (!client.Save(order))
            {
                ModelState.AddModelError(string.Empty, "Server error. Sorry.");
            }

            return View("Index");
        }

    }
}