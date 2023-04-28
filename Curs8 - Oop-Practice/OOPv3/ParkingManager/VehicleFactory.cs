using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{  
    public enum VehicleType
    {
        Car,
        Bus,
        Motorcycle
    }

    internal static class VehicleFactory
    {
        public static Vehicle CreateVehicle(VehicleType vehicleType, string plateNum, string color, int year, string manufacturer)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    return new Car(plateNum, color, year, manufacturer, vehicleType);

                case VehicleType.Bus:
                    return new Bus(plateNum, color, year, manufacturer, vehicleType);

                case VehicleType.Motorcycle:
                    return new Motorcycle(plateNum, color, year, manufacturer, vehicleType);
                default:
                    return null;
            }
        }
    }
}
