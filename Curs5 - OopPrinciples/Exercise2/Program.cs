namespace Exercise2
{
    internal class Program
    {
        /// <summary>
        /// Create a parameterless constructor and a constructor with different properties.
        /// Display the car details.
        /// </summary>
        static void Main()
        {
            string color = "white";
            int speed = 50;
            string brand = "ford";

            var vehicle = new Vehicle(color, speed);
            vehicle.VehicleDetails();

            var oldVehicle = new Vehicle();
            oldVehicle.VehicleDetails();

            var brandNewVehicle = new Vehicle(30);
            brandNewVehicle.VehicleDetails();

            var vehicleBrand = new Vehicle(color, speed, brand);
            vehicleBrand.VehicleDetails();
        }
    }
}
