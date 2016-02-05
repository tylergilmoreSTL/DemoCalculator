using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static decimal Add(decimal augend, decimal addend)
        {
            return (augend + addend);
        }

        public static decimal Subtract(decimal minuend, decimal subtrahend)
        {
            return (minuend - subtrahend);
        }

        public static decimal Multiply(decimal multiplicand, decimal multiplier)
        {
            return (multiplicand * multiplier);
        }

        public static decimal Divide(decimal dividend, decimal divisior)
        {
            return (dividend / divisior);
        }
       
    }
}
