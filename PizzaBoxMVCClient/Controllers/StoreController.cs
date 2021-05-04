using Microsoft.AspNetCore.Mvc;
using PizzaBoxMVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Controllers
{
  public class StoreController : Controller
  {
    Client client = new Client();
        
        public IActionResult Index() 
        {
            var stores = client.GetStores();
            return View(stores);
        }
        public IActionResult GetOrders() 
        {
            var orders = client.GetOrders();
            return View(orders);
        }
        
        public IActionResult UserLogin([Bind("UserID")]string UserID)
        {
            System.Diagnostics.Debug.WriteLine(" user id: " + UserID);
            return View(UserID);
        }
    }
    
}