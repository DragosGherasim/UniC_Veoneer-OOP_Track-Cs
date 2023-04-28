using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple1
{
    internal class NonMotorizedVeh : Vehicle
    {
        public NonMotorizedVeh(string color, int speed, string brand) : base(color, speed, brand)
        {

        }

        public override void SellVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
