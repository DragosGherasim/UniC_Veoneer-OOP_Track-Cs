using System;

namespace Exercise5
{
    internal class Program
    {
        /// <summary>
        /// Create an abstract method SellVehicle in base class.
        /// Implement in derived classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var car = new Car
            {
                Speed = 100,
                Color = "white"
            };

            car.SellVehicle();


            var bus = new Bus();
            bus.SellVehicle();
        }
    }
}
