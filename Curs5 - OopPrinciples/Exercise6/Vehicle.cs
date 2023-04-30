using System;

namespace Exercise6
{
    public abstract class Vehicle
    {
        public string Color = "yellow";
        public int Speed = 30;

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

        public abstract void SellVehicle();

        public virtual void Drive()
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
