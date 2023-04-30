using System;

namespace Exercise4
{
    internal class Program
    {
        /// <summary>
        /// Extend inheritance by creating 2 new categories, Motorized and NonMotorizedVehicle, and class Car, Bus and Bicycle as their inheritance.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var car = new Car
            {
                Speed = 100,
                Color = "white"
            };

            car.VehicleDetails();

            Vehicle vehicle = new Vehicle();
            vehicle.VehicleDetails();

            vehicle.Tyre = "all season";
            vehicle.ManufactureDate = 2019;
            Console.WriteLine(vehicle.Speed);


            var newCar = new Car("Ford", 30);
            newCar.VehicleDetails();

            MotorizedVehicle motorizedVehicle = new Bus();
            (motorizedVehicle as Bus).IsDoubleDecker = true;
            (motorizedVehicle as Bus).VehicleDetails();
        }
    }
}
