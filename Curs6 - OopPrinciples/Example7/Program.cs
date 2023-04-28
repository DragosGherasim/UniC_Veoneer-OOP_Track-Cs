namespace Example7
{

    internal class Program
    {
        /// <summary>
        /// Convert all base classes in abstract classes.
        /// Define one more method to be abstract.
        /// Implement it in derived classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           // var vehicle = new Vehicle();

            Vehicle vehicle = new Car();
            //vehicle.Stop();

            (vehicle as Car).Stop();

            Vehicle bus = new Bus();
            (bus as Bus).Stop();
        }
    }
}
