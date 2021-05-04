using Microsoft.AspNetCore.Mvc;
using PizzaBoxMVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Controllers
{
    public class UserController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var user = new User();

            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(Models.User user) 
        {
            client.CreateUser(user);
            return View();
        }


    }
}