using CalculatorWebAPI.States;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class LeftButton : IButtons
        {
            public LeftButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }


            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressLeft(calculator);
                calculator.CurrentState = new Parenthesis();
            }
        }
    }
    
}
