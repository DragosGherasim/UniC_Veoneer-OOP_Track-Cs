using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple1
{
    public abstract class Vehicle
    {
        //internal string Brand; // pt acelasi namespace

        private string _color; // propfull

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public Vehicle(string color ="red", int speed = 90, string brand = "Dacia", string tire = "all season") //ctor
        {
            Color = color;
            Speed = speed;
            Brand = brand;
        }

        private string _tire;

        public string Tire
        {
            get { return _tire; }
            set { _tire = value; }
        }

        private int _manufactureYear;

        public int ManuFactureYear
        {
            get { return _manufactureYear; }

            set {
                Speed = DateTime.Now.Year < value - 2 && value < DateTime.Now.Year ? 130 : 90;
                _manufactureYear = value; 
            }
        }


        public void Display()
        {
            Console.WriteLine($"Color : {Color}, Speed : {Speed}, Brand : {Brand} and Tire : {Tire}");
        }

        public abstract void Drive();

        public void Brake()
        {
            Console.WriteLine("Brake the car");
        }

        public virtual void SetUpSpeedLimit()
        {
            Console.WriteLine("Nothing to implement");
        }

        public abstract void SellVehicle();
    }
}
