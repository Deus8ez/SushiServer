using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class SetsInOrders
    {
        [Key]
        public int SetsInOrdersID { get; set; }
        public int SetID { get; set; }
        public int OrderID { get; set; }

        public Set Set { get; set; }
        public Order Order { get; set; }

    }
}
