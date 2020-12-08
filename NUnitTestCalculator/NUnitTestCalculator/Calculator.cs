using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCalculator
{
    public static class Calculator
    {
        public static int Plus(int x, int y)
        {
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            if (y == 0) return 0;

            return x / y;
        }
    }
}
