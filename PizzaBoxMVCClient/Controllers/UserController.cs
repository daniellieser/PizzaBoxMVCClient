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
            System.Diagnostics.Debug.WriteLine("  UserController: userid " + user.UserId);
            System.Diagnostics.Debug.WriteLine(" UserController username: " + user.UserName);
            System.Diagnostics.Debug.WriteLine(" UserController phone: " + user.UserPhone);
            client.CreateUser(user);
            return View("Welcome", user);
        }


    }
}