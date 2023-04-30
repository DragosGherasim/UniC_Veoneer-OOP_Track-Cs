namespace Example2
{
    internal class Program
    {
        /// <summary>
        /// Create an object from class Vehicle by assigning all properties from a constructor.
        /// Display the vehicle details. Create a parameterless constructor.
        /// Display the vehicle details.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string color = "white";
            int speed = 50;
            string brand = "not_dacia";
            var vehicle = new Vehicle(color, speed, brand);
            vehicle.VehicleDetails();

            var oldVehicle = new Vehicle();
            oldVehicle.VehicleDetails();
        }
    }
}
