using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Clock
    {
        public bool CanShowTime { get; set; } = false;
        public void ShowTime()
        {
            if (CanShowTime)
            {
                Console.WriteLine("Time is");
            }
            else
            {
                throw new ClockNotWorkinException("Clock not working");
            }
        }
    }
}
