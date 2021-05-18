using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class SetsInOrders
    {
        public int SetsInOrdersID { get; set; }
        public int SushiInSetsID { get; set; }
        public int OrderID { get; set; }

        public SushiInSets SushiInSets { get; set; }
        public Order Order { get; set; }

    }
}
