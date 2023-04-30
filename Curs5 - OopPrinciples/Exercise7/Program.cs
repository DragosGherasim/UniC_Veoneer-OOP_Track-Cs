using System.Collections.Generic;

namespace Exercise7
{

    internal class Program
    {
        /// <summary>
        /// Create a list of motorized objects. Call all the methods available.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            Vehicle bus = new Bus();

            //List<MotorizedVehicle> vehicles = new List<MotorizedVehicle>();
            //vehicles.Add(vehicle);
            //vehicles.Add(bus);

            List<Vehicle> vehicleType = new List<Vehicle>();
            vehicleType.Add(vehicle);
            vehicleType.Add(bus);

            MotorizedVehicle vehicle2 = new Car();
            MotorizedVehicle bus2 = new Bus();

            List<MotorizedVehicle> vehicles = new List<MotorizedVehicle>();
            vehicles.Add(vehicle2);
            vehicles.Add(bus2);


            foreach (var type in vehicleType)
            {
                type.Brake();
                type.SetUpSpeedLimit();
                type.VehicleDetails();
                type.Warning();

                if(type is Car _car)
                    _car.Stop();
            }
        }
    }
}
