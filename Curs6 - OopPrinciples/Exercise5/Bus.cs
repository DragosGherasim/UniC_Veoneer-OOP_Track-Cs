using System;

namespace Exercise5
{
    public class Bus : MotorizedVehicle
    {
        public bool IsDoubleDecker { get; set; }
        public override void Drive()
        {
            Console.WriteLine("Driving a bus");
        }

        public override void SellVehicle()
        {
            Console.WriteLine("Price of the bus is: 150E");
        }
    }
}
