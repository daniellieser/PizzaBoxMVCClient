using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Models
{
  public class User
  {
    public string UserName { get; set; }
    public int UserId { get; set; }
    public string UserPhone { get; set; }
        public User()
        {
            Orders = new HashSet<Order>();
        }
        public virtual ICollection<Order> Orders { get; set; }
    }
}