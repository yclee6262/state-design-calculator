using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorLibrary.States.Operators
{
    public class Square : IOperator
    {
        public int Priority { get => 4; }

        public string GetAnswer(double[] doubles)
        {
            return Math.Sqrt(doubles[0]).ToString();
        }

        public string GetString(double currentNumber, CalculatorProperties calculator)
        {
            return calculator.RootText(currentNumber.ToString());
        }

        public string GetSymbol()
        {
            return "";
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
        }
    }
}
