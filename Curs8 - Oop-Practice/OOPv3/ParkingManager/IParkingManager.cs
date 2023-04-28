using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal interface IParkingManager
    {
        ParkingArea GetMostAvailableParkingArea(List<ParkingArea> parkingAreas, VehicleType vehicleType);
        void DisplayVehicleTypeFromParkingArea(ParkingArea parkingArea, VehicleType vehicleType);
        List<int> GetEmptySlotsReport(ParkingArea parkingArea);
    }
}
