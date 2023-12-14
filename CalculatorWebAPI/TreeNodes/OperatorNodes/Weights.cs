using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWebAPI.TreeNodes.OperatorNodes
{
    public static class Weights
    {
        public const int Plus = 2;
        public const int Minus = 2;
        public const int Multiply = 3;
        public const int Divide = 3;
        public const int Equal = 1;
        public const int LeftParenthesis = 0;
    }
}
