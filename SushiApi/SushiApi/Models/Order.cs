using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public decimal CustomerPayment { get; set; }

        public DateTime OrderPlaced { get; set; }

        public Customer Customer { get; set; }

        public virtual ICollection<SushiInSets> SushiInSets { get; set; }
    }
}
