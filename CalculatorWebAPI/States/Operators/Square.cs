using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorWebAPI.TreeNodes;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI.States.Operators
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

        public OperatorNode GetOperatorNode()
        {
            return new PlusNode(Signs.PlusSign); // 用不到隨便設
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
        }
    }
}
