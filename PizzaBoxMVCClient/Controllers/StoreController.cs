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
  }
}