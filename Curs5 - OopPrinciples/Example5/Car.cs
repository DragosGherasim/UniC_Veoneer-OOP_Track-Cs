using System;

namespace Example5
{
    public class Car : MotorizedVehicle
    {
        public Engine Engine;
        public Wheel Wheel;

        public Car()
        {
        }

        public Car(string brand, int speed) : base(brand, speed)
        {

        }

        public void Drive()
        {
            Console.WriteLine($"Drive with high speed");
        }

        public void Drive(bool isBadWeather)
        {
            if (isBadWeather)
                Console.WriteLine($"Drive with reduced speed");
        }

        public override void SetUpSpeedLimit()
        {
            Speed = 130;
        }
    }
}
