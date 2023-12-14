using CalculatorWebAPI.TreeNodes.OperatorNodes;
using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class DivideButton : IButtons
        {
            public DivideButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressOperator(new Divide(), calculator);
                calculator.TopList.Add(Signs.DivideSign);
                calculator.TopText = string.Concat(calculator.TopList);
                calculator.CurrentState = new Calculate();
                calculator.LastOperator = new Divide();
            }
        }
    }

}
