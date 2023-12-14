using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.States.Operators
{
    public class EqualOperator : IOperator
    {
        public int Priority { get => 1; }

        public string GetAnswer(double[] doubles)
        {
            return doubles[0].ToString();
        }

        public string GetString(double currentNumber, CalculatorProperties calculator)
        {
            return currentNumber.ToString();
        }

        public string GetSymbol()
        {
            return Signs.EqualSign;
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
        }
    }
}
