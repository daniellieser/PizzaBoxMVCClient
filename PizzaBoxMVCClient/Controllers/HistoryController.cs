using Microsoft.AspNetCore.Mvc;
using PizzaBoxMVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Controllers
{
  public class HistoryController : Controller
  {
    Client client = new Client();
        public IActionResult Index(int id)
        {
            var history = client.GetHistory(id);
            return View("Index", history);
        }

        // public IActionResult GetCustOrders(string UserId) 
        // {
        //var history = client.GetHistory(int.Parse(UserId));
        //return View(history);
        // return View("Index", UserId);
        // }
    }
}