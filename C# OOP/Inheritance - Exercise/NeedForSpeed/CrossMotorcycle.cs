﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class CrossMotorcycle : Vehicle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            FuelConsumption = DefaultFuelConsumption;
        }
    }
}
