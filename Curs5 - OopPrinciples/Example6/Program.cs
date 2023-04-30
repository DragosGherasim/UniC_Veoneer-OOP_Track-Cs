namespace Example6
{

    internal class Program
    {
        /// <summary>
        /// Create a function called Drive. Overload that function.
       /// Create a function in base class called SetUpSpeedLimit.
       /// Override that function and implement it in derived classes.
       /// </summary>
       /// <param name="args"></param>
        static void Main(string[] args)
        {
            var car = new Car
            {
                Speed = 100,
                Color = "white"
            };

            car.Drive();
            car.VehicleDetails();

            car.Drive(true);
            car.VehicleDetails();

            car.SetUpSpeedLimit();

            var bus = new Bus();
            bus.SetUpSpeedLimit();
        }
    }
}
