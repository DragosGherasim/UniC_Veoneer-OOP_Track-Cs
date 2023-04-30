namespace Example3
{
    internal class Program
    {
        /// <summary>
        /// Extend class Vehicle by creating a property tire.
        /// Create a method to display a warning if tire type is not suitable.
        /// Convert all fields to properties.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            string color = "white";
            int speed = 50;
            string tire = "summer type";

            var vehicle = new Vehicle(color, speed);
            vehicle.Tire = tire;
            vehicle.DisplayVehicleDetails();

            var newVehicle = new Vehicle(color, speed);
            newVehicle.DisplayVehicleDetails();
        }
    }
}
