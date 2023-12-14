using CalculatorWebAPI.States;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class RightButton : IButtons
        {
            public RightButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }


            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressRight(calculator);
                calculator.CurrentState = new AppendOperator();
            }
        }
    }
    
    
}
