using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        public static int Pro(int x, int y)
        {
            return x * y;
        }

        public static int Mod(int x, int y)
        {
            return x % y;
        }
    }
}
