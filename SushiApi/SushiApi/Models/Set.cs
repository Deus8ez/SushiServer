using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class Set
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public int? Rating { get; set; }

        public bool Custom { get; set; }

        public virtual ICollection<SushiInSets> SushiInSets { get; set; }

    }
}
