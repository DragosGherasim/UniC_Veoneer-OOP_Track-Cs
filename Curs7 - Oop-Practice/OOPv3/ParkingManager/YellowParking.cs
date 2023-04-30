using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class YellowParking: ParkingArea
    {
        public YellowParking(List<Vehicle> vehiclesList, string name)
            : base(vehiclesList, name)
        {
            MAX_NUM_CARS = 10;
            MAX_NUM_BUSES = 2;
            MAX_NUM_MOTORCYCLES = 5;
        }
    }
}
