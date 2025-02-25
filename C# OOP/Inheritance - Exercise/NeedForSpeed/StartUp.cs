using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle motorcycle = new Motorcycle(10, 2.3);
            motorcycle.Drive(24);
            Console.WriteLine(motorcycle.Fuel);

            RaceMotorCycle rm = new RaceMotorCycle(150, 50);
            rm.Drive(12);
            Console.WriteLine(rm.Fuel);

            Car car = new Car(100, 20);
            car.Drive(3);
            Console.WriteLine(car.Fuel);
        }
    }
}
