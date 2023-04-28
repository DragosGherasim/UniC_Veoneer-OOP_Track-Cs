namespace Exercise3
{
    /// <summary>
    /// Extend class Vehicle by creating a property manufacturer year.
    /// If the car age is less than 2 years, set up the speed to 130 from a method. Else, limit the speed up to 90.
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            int speed = 100;
            var vehicle = new Vehicle { Speed = speed };
            vehicle.VehicleDetails();

            vehicle.ManufactureDate = 2021;
            vehicle.VehicleDetails();
        }
    }
}
