using System;

namespace Example8
{
    public class Car : MotorizedVehicle
    {
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

        public override void Stop()
        {
            if (Speed > 130)
                Brake();
            else Console.WriteLine("Reducing speed");
        }
    }
}
