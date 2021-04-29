using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Models
{
  public class Order
  {
       // public Store Store { get; set; }
       
       public List<Pizza> Pizzas { get; set; }
        public string Summary { get; set; }
        public User User { get; set; }
        public int OrderId { get; set; }
       

        public DateTime? Time { get; set; }
    }
}