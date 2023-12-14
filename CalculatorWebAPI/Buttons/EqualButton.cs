using CalculatorWebAPI.States;
using CalculatorWebAPI.TreeNodes;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class EqualButton : IButtons
        {
            public EqualButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressEqual(calculator);
                calculator.TopList.Add(Signs.EqualSign);
                calculator.TopText = string.Concat(calculator.TopList);
                calculator.PostfixQueue = new Queue<TreeNode>();
                calculator.TopList = new List<string>();
                calculator.CurrentValue = 0;
                calculator.CurrentString = string.Empty;
                calculator.CurrentState = new Equal();
            }
        }
    }
    
}
