using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class ParkingManager: IParkingManager
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public ParkingManager(string name)
        {
            this.name = name;
        }

        public void DisplayVehicleTypeFromParkingArea(ParkingArea parkingArea, VehicleType vehicleType)
        {
            parkingArea.VehiclesList.Where(vehicle => vehicle.Type == vehicleType).ToList().ForEach(vehicle => vehicle.Display());
        }

        public ParkingArea GetMostAvailableParkingArea(List<ParkingArea> parkingAreas, VehicleType vehicleType)
        { 
            ParkingArea mostAvailableParkingArea = parkingAreas
             .OrderByDescending(pa => vehicleType switch
                {
                    VehicleType t when t is VehicleType.Car => pa.MAX_NUM_CARS - pa.GetNumberOfVehicleType(VehicleType.Car),
                    VehicleType t when t is VehicleType.Bus => pa.MAX_NUM_BUSES - pa.GetNumberOfVehicleType(VehicleType.Bus),
                    VehicleType t when t is VehicleType.Motorcycle => pa.MAX_NUM_MOTORCYCLES - pa.GetNumberOfVehicleType(VehicleType.Motorcycle),
                })
                .FirstOrDefault();

            return mostAvailableParkingArea != null
                ? mostAvailableParkingArea
                : null;
        }

        public List<int> GetEmptySlotsReport(ParkingArea parkingArea)
        {
            return new List<int>{parkingArea.MAX_NUM_CARS - parkingArea.GetNumberOfVehicleType(VehicleType.Car),
                                parkingArea.MAX_NUM_BUSES - parkingArea.GetNumberOfVehicleType(VehicleType.Bus),
                                parkingArea.MAX_NUM_MOTORCYCLES - parkingArea.GetNumberOfVehicleType(VehicleType.Motorcycle) };
        }

        /*public string GetMostAvailableParkingArea(List<ParkingArea> parkingAreas, string vehicleType)
        {
			int maxNumOfEmptySlots = 0;
            string mostAvailableParkingArea = "";

            if (vehicleType == "Car")
			{
				foreach(ParkingArea currentParkingArea in parkingAreas)
				{
					int numOfEmptyCarSlots = currentParkingArea.MAX_NUM_CARS - currentParkingArea.CarsList.Count();

					if (maxNumOfEmptySlots < numOfEmptyCarSlots)
					{
						maxNumOfEmptySlots = numOfEmptyCarSlots;
						mostAvailableParkingArea = currentParkingArea.GetType().FullName.Substring("ParkingManager.".Length);
					}
				}
			}
			else if (vehicleType == "Bus")
            {
                foreach (ParkingArea currentParkingArea in parkingAreas)
                {
                    int numOfEmptyCarSlots = currentParkingArea.MAX_NUM_BUSES - currentParkingArea.BusesList.Count();

                    if (maxNumOfEmptySlots < numOfEmptyCarSlots)
                    {
                        maxNumOfEmptySlots = numOfEmptyCarSlots;
                        mostAvailableParkingArea = currentParkingArea.GetType().FullName.Substring("ParkingManager.".Length);
                    }
                }
            }
			else
			{
                foreach (ParkingArea currentParkingArea in parkingAreas)
                {
                    int numOfEmptyCarSlots = currentParkingArea.MAX_NUM_MOTORCYCLES - currentParkingArea.MotorcyclesList.Count();

                    if (maxNumOfEmptySlots < numOfEmptyCarSlots)
                    {
                        maxNumOfEmptySlots = numOfEmptyCarSlots;
                        mostAvailableParkingArea = currentParkingArea.GetType().FullName.Substring("ParkingManager.".Length);
                    }
                }
            }

            return mostAvailableParkingArea;
        }*/
    }
}
