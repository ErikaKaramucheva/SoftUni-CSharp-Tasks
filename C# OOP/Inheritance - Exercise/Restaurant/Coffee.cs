﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Coffee :HotBeverage 
    {
        public Coffee(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }

        public double CoffeeMilliliters { get; set; } = 50;
        public decimal CoffeePrice { get; set; } = 3.5m;
        public double Caffeine { get; set; }
    }
}
