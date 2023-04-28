using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exemple1
{
    internal class Car: MotorizedVeh
    {
        public Car() : base(color : "red", speed : 40, brand: "dacia")
        {

        }

        public Car(string brand, int speed) : base(brand, 30, "ford")
        {

        }

        public void Drive()
        {
            Console.WriteLine("Driving with high speed");
        }

        public void Drive(bool isBadWeather)
        {
            if (isBadWeather)
            {
                Console.WriteLine("Driving with reduced speed");
            }
        }

        public override void SetUpSpeedLimit()
        {
            Console.WriteLine("Speed limit is 140");
        }
    }
}
