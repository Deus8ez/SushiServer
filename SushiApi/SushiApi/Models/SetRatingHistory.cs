using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models
{
    public class SetRatingHistory
    {
        [Key]
        public int SetInRatingHistoryID { get; set; }

        public int SetID { get; set; }

        public int Rating { get; set; }

        public Set Set { get; set; }

    }
}
