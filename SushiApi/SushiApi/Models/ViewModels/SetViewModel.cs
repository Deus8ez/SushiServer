using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models.ViewModels
{
    public class SetViewModel
    {
        
        //public string Name { get; set; }
        //public int Id { get; set; }
        //public decimal Cost { get; set; }
        //public bool Custom { get; set; }
        //public int? Rating { get; set; }          
        public Set Set { get; set; }
        public List<Sushi> Sushis { get; set; }
    }
}
