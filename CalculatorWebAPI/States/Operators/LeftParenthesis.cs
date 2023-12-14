using CalculatorWebAPI.TreeNodes;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI.States.Operators
{
    public class LeftParenthesis : IOperator
    {
        public int Priority { get => 0; }

        public string GetAnswer(params double[] doubles)
        {
            return "";
        }

        public OperatorNode GetOperatorNode()
        {
            return new LeftParenthesisNode(Signs.Left);
        }

        public string GetString(double currentValue, CalculatorProperties calculator)
        {
            return currentValue.ToString();
        }

        public string GetSymbol()
        {
            return Signs.Left;
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
        }
    }
}
