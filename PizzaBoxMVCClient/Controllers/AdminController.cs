using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PizzaBoxMVCClient.Models;

namespace PizzaBoxMVCClient.Controllers
{
    public class AdminController : Controller
    {
        public string url = "https://localhost:44305/";
        public List<Order> Orders { get; set; }

        [HttpGet]
        public IActionResult AllOrders()
        {
           
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var responseTask = client.GetAsync("Order"); // HTTP GET
                responseTask.Wait();

                var result = responseTask.Result; // This holds the output

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Order>>();
                    readTask.Wait();
                    Orders = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Sorry.");
                }
            }
            return View(Orders);
        }
    }
}
