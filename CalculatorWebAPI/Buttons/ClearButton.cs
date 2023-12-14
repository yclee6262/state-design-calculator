using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class ClearButton : IButtons
        {
            public ClearButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentValue = 0;
                calculator.CurrentString = string.Empty;
                calculator.TopList = new List<string>();
                calculator.TopText = string.Empty;
                calculator.OutputText = Signs.ZERO;
                calculator.NumStack = new Stack<double>();
                calculator.LastOutput = 0;
                calculator.NumStack.Push(calculator.LastOutput);
                calculator.OperatorStack = new Stack<IOperator>();
                calculator.CurrentState = new Initial();
                calculator.LastOperator = new NoOperators();
                calculator.OperatorStack.Push(calculator.LastOperator);
                calculator.OperatorNodeStack = new Stack<OperatorNode>();
                calculator.PostfixQueue = new Queue<TreeNode>();
                calculator.LeftParenthesisCount = 0;
                calculator.HaveParenthesis = false;
                calculator.PreorderString = string.Empty;
                calculator.InorderString = string.Empty;
                calculator.PostorderString = string.Empty;
            }
        }
    }
    
}
