using System;

namespace Exercise2
{
    public class Vehicle
    {
        public string Color = "yellow";
        public int Speed = 30;
        public string Brand = "Ford";

        public Vehicle() { }
        public Vehicle(string color, int speed)
        {
            Color = color;
            Speed = speed;
        }

        public Vehicle(string color, int speed, string brand)
        {
            Color = color;
            Speed = speed;
            Brand = brand;
        }

        public Vehicle(int speed)
        {
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
    }
}
