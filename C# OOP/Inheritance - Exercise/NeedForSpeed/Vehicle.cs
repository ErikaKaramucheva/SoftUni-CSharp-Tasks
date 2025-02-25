using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; } =1.25;
        public virtual double FuelConsumption  { get; set; }

        public Vehicle(int horsePower,double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            FuelConsumption = DefaultFuelConsumption;
        }

        public virtual void Drive(double kilometers)
        {
            double neededFuel = FuelConsumption * kilometers;
            if (Fuel >= neededFuel)
            {
                Fuel-=neededFuel;
            }
            else
            {
                Console.WriteLine(this.GetType() + " - Not enough fuel!");
            }
        }

    }
}
