using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class RaceMotorCycle : Motorcycle
    {
        public RaceMotorCycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            FuelConsumption = DefaultFuelConsumption;
        }
        public override double FuelConsumption => 8;

    }
}
