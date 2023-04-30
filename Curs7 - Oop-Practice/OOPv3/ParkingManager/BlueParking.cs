using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class BlueParking: ParkingArea
    {
        public BlueParking(List<Vehicle> vehiclesList, string name)
            : base(vehiclesList, name)
        {
            MAX_NUM_CARS = 11;
            MAX_NUM_BUSES = 1;
            MAX_NUM_MOTORCYCLES = 7;
        }
    }
}
