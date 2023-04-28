using System;

namespace Example3
{
    public class Vehicle
    {
        private string _color;
        public string Color
        {
            get => _color;
            set => _color = value;
        }

        private int _speed;
        public int Speed
        {
            get => _speed;
            set => _speed = value;
        }

        public string Brand { get; set; } = "Ford";

        private string _tire = "all season";
        public string Tire
        {
            get => _tire;
            set
            {
                if (value.StartsWith("summer"))
                    Warning();

                _tire = value;
            }
        }

        public Vehicle(string color, int speed)
        {
            Color = color;
            Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Brake()
        {
            Console.WriteLine("Brake");
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Our color car is {Color}");
            Console.WriteLine($"Our car's speed is {Speed}");
        }

        public void Warning()
        {
            Console.WriteLine("You need to change your tires according with the season.");
        }
    }
}
