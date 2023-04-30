namespace Exercise4
{
    public class MotorizedVehicle : Vehicle
    {
        public MotorizedVehicle() : base(color: "black", speed: 40)
        {
        }

        public MotorizedVehicle(string color, int speed) : base(color, speed)
        {

        }
    }
}
