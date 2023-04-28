using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal abstract class Vehicle
    {
		protected string plateNumber;

		public string PlateNumber
		{
			get { return plateNumber; }
			set { plateNumber = value; }
		}

		protected string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		protected int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		protected string manufacturer;

		public string Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		private VehicleType type;

		public VehicleType Type
		{
			get { return type; }
			set { type = value; }
		}

		public Vehicle(string plateNum, string color, int year, string manufacturer, VehicleType type)
		{
			this.plateNumber = plateNum;
			this.color = color;
			this.year = year;
			this.manufacturer = manufacturer;
			this.type = type;
		}

		public void Display()
		{
			Console.WriteLine($"Plate Number : {plateNumber}, Color : {color}, Year : {year}, Manufacturer : {manufacturer}");
		}

		public void Park(ParkingArea parkingArea)
		{
            Console.WriteLine("Your vehicle is parked in " + parkingArea.Name + " !");

            parkingArea.VehiclesList.Add(this);
		}

		public void LeavingPark(ParkingYard parkingYard)
		{
			var parkingArea = parkingYard.ParkingAreas.Where(parkingArea => parkingArea.VehiclesList.Contains(this)).FirstOrDefault();

			parkingArea.VehiclesList.Remove(this);

            Console.WriteLine("Your vehicle is leaving the " + parkingArea.Name + " !");
        }
	}
}
