using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal abstract class ParkingArea
    {
        public int MAX_NUM_CARS { protected set;  get; }
		public int MAX_NUM_BUSES { protected set; get; }
        public int MAX_NUM_MOTORCYCLES { protected set;  get; }

        protected string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		protected List<Vehicle> vehiclesList;

		public List<Vehicle> VehiclesList
		{
			get { return vehiclesList; }
			set { vehiclesList = value; }
		}

		public ParkingArea(List<Vehicle> vehiclesList, string name)
		{
			this.vehiclesList = vehiclesList;
			this.name = name;
		}

		public int GetNumberOfVehicleType(VehicleType vehicleType)
		{
			return vehiclesList.Count(vehicle => vehicle.Type == vehicleType);
		}
	}
}