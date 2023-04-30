namespace Exercise8
{
    public abstract class MotorizedVehicle : Vehicle, IMotorizedVehicle
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
        public bool Diesel { get; set; }
    }
}
