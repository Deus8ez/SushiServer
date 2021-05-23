using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models.ViewModels
{
    public class OrderViewModel
    {
        public List<SetViewModel> Sets { get; set; }

        public Customer Customer { get; set; }

        public string OrderPlaced { get; set; }

        public decimal Payment { get; set; }
    }
}
