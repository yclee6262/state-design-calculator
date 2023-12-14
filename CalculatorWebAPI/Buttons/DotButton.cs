using CalculatorWebAPI.States;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class DotButton : IButtons
        {
            public DotButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressDot(calculator);
                calculator.CurrentState = new AppendDot();
            }
        }
    }

}
