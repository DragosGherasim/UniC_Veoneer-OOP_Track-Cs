using System;

namespace Exercise6
{
    public class Car : MotorizedVehicle
    {
        public Car()
        {
        }

        public Car(string brand, int speed) : base(brand, speed)
        {

        }

        public override void Drive()
        {
            Console.WriteLine("Driving a car");
        }

        public override void SellVehicle()
        {
            Console.WriteLine("Price of the car is: 200E");
        }
    }
}
