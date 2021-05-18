using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
