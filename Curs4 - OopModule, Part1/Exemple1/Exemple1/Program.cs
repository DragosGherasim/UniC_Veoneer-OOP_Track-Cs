namespace Exemple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Tire = "summer type";
            vehicle.Display();

            vehicle.Drive();
            vehicle.Brake();

            int speed = 100;
            Vehicle veh = new Vehicle();
            veh.Speed = speed;
            veh.Display();

            veh.ManuFactureYear = 2021;
            veh.Display();

            Car car = new Car();
            car.Display();

            MotorizedVeh motorizedVehicle = new Bus();
            (motorizedVehicle as Bus).DoubleDecker = true;

            List<MotorizedVeh> vehicles = new List<MotorizedVeh>();

            vehicles.Add(motorizedVehicle);
            vehicles.Add(new Car());
            
            foreach(var vehicleType in vehicles)
            {
                if (vehicleType is Bus)
                {
                    Console.WriteLine("Type is bus");
                }
            }

            Car new_car = new Car();
            car.VehicleEngine = new Engine();
            car.Wheel = new Wheel();
        }
    }
}