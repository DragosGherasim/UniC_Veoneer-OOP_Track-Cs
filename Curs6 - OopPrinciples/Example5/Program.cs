using System;

namespace Example5
{

    internal class Program
    {
        /// <summary>
        /// Create a class engine and a class wheel. Add them to car class. Create an object with them.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var car = new Car();
            car.Engine = new Engine();
            car.Wheel = new Wheel();

            var engine = new Engine();
            var wheel = new Wheel();
        }
    }
}
