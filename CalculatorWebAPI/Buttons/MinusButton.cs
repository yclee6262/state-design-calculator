using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class MinusButton : IButtons
        {
            public MinusButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressOperator(new Minus(), calculator);
                calculator.TopList.Add(Signs.MinusSign);
                calculator.TopText = string.Concat(calculator.TopList);
                calculator.CurrentState = new Calculate();
                calculator.LastOperator = new Minus();
            }
        }
    }
    
}
