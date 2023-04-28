using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple1
{
    internal class Bus: MotorizedVeh
    {
		private bool _doubleDecker;

		public bool DoubleDecker
		{
			get { return _doubleDecker; }
			set { _doubleDecker = value; }
		}

		public Bus(string color, int speed, string brand) : base(color, speed, brand)
		{

		}

		public Bus()
		{

		}

        public override void SetUpSpeedLimit()
        {
			Console.WriteLine("Speed limit is 90");
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
