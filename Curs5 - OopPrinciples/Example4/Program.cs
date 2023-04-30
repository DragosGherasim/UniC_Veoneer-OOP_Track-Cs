namespace Example4
{
    internal class Program
    {
        /// <summary>
        /// Create a class Car which inherit from class Vehicle.
        /// Create its own constructor and display car details.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.VehicleDetails();

            vehicle.Tyre = "all season";
            vehicle.ManufactureDate = 2019;

            vehicle.VehicleDetails();

            var newCar = new Car("Ford", 30);
            newCar.VehicleDetails();
        }
    }
}
