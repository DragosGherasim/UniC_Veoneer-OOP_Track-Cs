using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    internal class Car: Vehicle
    {
        public Car(string plateNum, string color, int year, string manufacturer, VehicleType type)
            : base(plateNum, color, year, manufacturer, type)
        {
            
        }
    }
}
