﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melidya.WebUI.Models
{
    public class SepetModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal? Price { get; set; }
    }
}