using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models.ViewModels
{
    public class SetViewModel
    {
        
        public Set Set { get; set; }

        public List<Sushi> Sushis { get; set; }
    }
}
