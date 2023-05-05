﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class ClockNotWorkinException : Exception
    {
        public ClockNotWorkinException(string customMessage) : base(message : "Clock is not working")
        {
        }
    }
}
