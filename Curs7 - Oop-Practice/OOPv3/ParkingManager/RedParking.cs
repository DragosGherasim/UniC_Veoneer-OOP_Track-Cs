using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class RedParking: ParkingArea
    {
        public RedParking(List<Vehicle> vehiclesList, string name)
            : base(vehiclesList, name)
        {
            MAX_NUM_CARS = 5;
            MAX_NUM_BUSES = 3;
            MAX_NUM_MOTORCYCLES = 2;
        }
    }
}
