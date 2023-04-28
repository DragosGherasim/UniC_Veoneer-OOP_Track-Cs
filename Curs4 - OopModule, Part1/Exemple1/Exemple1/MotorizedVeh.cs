using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple1
{
    internal abstract class MotorizedVeh : Vehicle // pentru ca este abstracta nu este obligatoriu sa definesti functia abstr din Veh
    {
        public Engine VehicleEngine;
        public Wheel Wheel;

        public MotorizedVeh(string color, int speed, string brand) : base(color, speed, brand)
        {

        }

        public MotorizedVeh()
        {

        }

        public override void SetUpSpeedLimit()
        {
            base.SetUpSpeedLimit();
        }

        public override void SellVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
