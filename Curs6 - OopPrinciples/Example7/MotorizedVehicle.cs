using System;

namespace Example7
{
    public abstract class MotorizedVehicle : Vehicle
    {
        public MotorizedVehicle() : base(color: "black", speed: 40)
        {
        }

        public MotorizedVehicle(string color, int speed) : base(color, speed)
        {
        }

        public void Stop(bool obstacle)
        {
            if (obstacle)
                Brake();
        }

        public abstract void Stop();
    }
}
