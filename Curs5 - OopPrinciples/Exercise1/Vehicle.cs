using System;

namespace Exercise1
{
    public class Vehicle
    {
        public string Color;
        public int Speed;
        public string Brand;

        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Brake()
        {
            Console.WriteLine("Brake");
        }
    }
}
