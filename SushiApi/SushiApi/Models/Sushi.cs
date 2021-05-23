using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class Sushi
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal CostPerPiece { get; set; }
        public int? Amount { get; set; }
        public virtual ICollection<SushiInSets> SushiInSets { get; set; }

    }
}
