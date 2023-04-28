namespace Example6
{
    public class Bus : MotorizedVehicle
    {
        public bool IsDoubleDecker { get; set; }

        public override void SetUpSpeedLimit()
        {
            Speed = 90;
        }
    }
}
