using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            FuelConsumption = DefaultFuelConsumption;
        }

        public override double FuelConsumption { get => base.FuelConsumption ; set => base.FuelConsumption = 3; }
    }
}
