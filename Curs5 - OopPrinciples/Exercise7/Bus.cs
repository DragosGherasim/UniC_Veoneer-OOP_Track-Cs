using System;

namespace Exercise7
{
    public class Bus : MotorizedVehicle
    {
        public bool IsDoubleDecker { get; set; }

        public override void SetUpSpeedLimit()
        {
            Speed = 90;
        }

        public override void Stop()
        {
            if (Speed > 90)
                Brake();
            else Console.WriteLine("Reducing speed");
        }
    }
}
