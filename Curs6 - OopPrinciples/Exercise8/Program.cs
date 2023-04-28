namespace Exercise8
{
    internal class Program
    {
        /// <summary>
        /// Add more methods to interfaces. Call them when creating objects.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IVehicle car = new Car("color", 20);
            IVehicle bus = new Bus();

            car.VehicleDetails();
            bus.VehicleDetails();
        }
    }
}
