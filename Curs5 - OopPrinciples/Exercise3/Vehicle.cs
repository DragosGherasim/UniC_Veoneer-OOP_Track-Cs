using System;

namespace Exercise3
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

        public string Brand { get; set; } = "RangeRover";

        private string _tyre;
        public string Tyre
        {
            get => _tyre;
            set
            {
                if (value.StartsWith("summer"))
                    Warning();

                _tyre = value;
            }
        }

        private int _manufactureDate;
        public int ManufactureDate
        {
            get => _manufactureDate;
            set
            {
                Speed = DateTime.Now.Year - 2 < value && value < DateTime.Now.Year ? 130 : 90;

                _manufactureDate = value;
            }
        }


        public Vehicle() { }
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

        public void VehicleDetails()
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
