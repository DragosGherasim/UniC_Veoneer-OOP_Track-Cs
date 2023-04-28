using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class ParkingYard
    {
        private List<ParkingArea> parkingAreasList;
        public List<ParkingArea> ParkingAreas
        {
            get => parkingAreasList;

            set => parkingAreasList = value;
        }

        private IParkingManager parkingManager;
        public IParkingManager ParkingManager
        {
            get => parkingManager;

            set => parkingManager = value;
        }

        public ParkingYard(List<ParkingArea> parkingAreasList, IParkingManager parkingManager)
        {
            this.parkingAreasList = parkingAreasList;
            this.parkingManager = parkingManager;
        }

        public ParkingArea GetMostAvailableParkingArea(VehicleType vehicleType)
        {
            return parkingManager.GetMostAvailableParkingArea(parkingAreasList, vehicleType);
        }

        public void DisplayVehicleTypeFromParkingArea(ParkingArea parkingArea, VehicleType vehicleType)
        {
            parkingManager.DisplayVehicleTypeFromParkingArea(parkingArea, vehicleType);
        }

        public void DisplayEmptySlotsReportFromParkingArea(ParkingArea parkingArea)
        {
            Console.Write("Car - Bus - Motorcycle : ");

            parkingManager.GetEmptySlotsReport(parkingArea).ForEach(emptySlots => Console.Write(emptySlots + " "));
        }
}
}
