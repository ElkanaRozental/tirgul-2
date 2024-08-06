using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tirgul_2
{
    public class MathOperations
    {
        public double Add(double x, double y)
        {
            Calculator clc = new Calculator();
            return clc.Add(x, y);
        }

    }
}
