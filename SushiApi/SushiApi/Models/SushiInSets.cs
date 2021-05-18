using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class SushiInSets
    {
        public int SushiInSetsID { get; set; }
        public int SetID { get; set; }
        public int SushiID { get; set; }
        public Sushi Sushi { get; set; }
        public Set Set { get; set; }

    }
}
