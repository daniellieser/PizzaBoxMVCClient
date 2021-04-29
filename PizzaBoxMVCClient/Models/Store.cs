using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxMVCClient.Models
{
  public class Store
  {
    public string Name { get; set; }
    public int StoreId { get; set; }
        public Store()
        {
            Orders = new HashSet<Order>();
        }
        public virtual ICollection<Order> Orders { get; set; }
    }
}