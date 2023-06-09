﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}
