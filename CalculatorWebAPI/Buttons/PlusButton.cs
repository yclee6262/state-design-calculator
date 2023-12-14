using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class PlusButton : IButtons
        {
            public PlusButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }


            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressOperator(new Plus(), calculator);
                calculator.TopList.Add(Signs.PlusSign);
                calculator.TopText = string.Concat(calculator.TopList);
                calculator.CurrentState = new Calculate();
                calculator.LastOperator = new Plus();
            }
        }
    }
    
}
