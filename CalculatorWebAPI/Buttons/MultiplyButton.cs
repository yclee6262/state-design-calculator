using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class MultiplyButton : IButtons
        {
            public MultiplyButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressOperator(new Multiply(), calculator);
                calculator.TopList.Add(Signs.MultiplySign);
                calculator.TopText = string.Concat(calculator.TopList);
                calculator.CurrentState = new Calculate();
                calculator.LastOperator = new Multiply();
            }
        }
    }
    
}
