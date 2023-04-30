using System;

namespace Exercise5
{
    public class MotorizedVehicle : Vehicle
    {
        public MotorizedVehicle() : base(color: "black", speed: 40)
        {
        }

        public MotorizedVehicle(string color, int speed) : base(color, speed)
        {
        }

        public void Stop()
        {
            if (Speed > 130)
                Brake();
            else Console.WriteLine("Reducing speed");
        }

        public void Stop(bool obstacle)
        {
            if (obstacle)
                Brake();
        }

        public override void SellVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
