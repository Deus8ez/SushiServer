﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SushiApi.Models.ViewModels
{
    public class SushiViewModel
    {
        public List<Set> Sets { get; set; }

        public List<Sushi> Sushis { get; set; }
    }
}
