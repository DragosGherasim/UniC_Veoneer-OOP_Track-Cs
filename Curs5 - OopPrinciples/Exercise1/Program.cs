using System;

namespace Exercise1
{
    internal class Program
    {
        /// <summary>
        /// Extend the class vehicle with 1 more property called brand and 2 methods, drive and brake.
        /// Create an instance of that class and call the methods.
        /// Optional: Create another object and display it.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var vehicle = new Vehicle();
            vehicle.Color = "black";
            vehicle.Speed = 60;
            vehicle.Brand = "Dacia";

            vehicle.Drive();
            vehicle.Brake();

            //optional
            vehicle = new Vehicle();
            vehicle.Color = "red";
            Console.WriteLine(vehicle.Color);
        }
    }
}
