namespace Example8
{

    internal class Program
    {
        /// <summary>
        /// Create 2 interfaces, IVehicle and IMotorizedVehicle.
        /// Add a new property named diesel. Display all properties of a car through interface.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var car = new Car();
            car.Diesel = true;

            //var newCar = new Car();

            IVehicle newCar = new Car();
            newCar.Brake();
            (newCar as Car).Speed = 30;

            IMotorizedVehicle newMotor = new Bus();
            (newMotor as Bus).VehicleDetails();
        }
    }
}
