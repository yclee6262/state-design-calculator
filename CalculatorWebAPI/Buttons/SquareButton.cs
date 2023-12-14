using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class SquareButton : IButtons
        {
            public SquareButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressOperator(new Square(), calculator);
                calculator.CurrentState = new AppendNumber();
                calculator.TopList = new List<string>();
            }
        }
    }
    
}
