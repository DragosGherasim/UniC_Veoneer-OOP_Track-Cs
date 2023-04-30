namespace Example4
{
    public class Car : Vehicle
    {
        public Car() : base(color: "black", speed: 40)
        {
        }

        public Car(string brand, int speed) : base(brand, speed)
        {

        }
    }
}
