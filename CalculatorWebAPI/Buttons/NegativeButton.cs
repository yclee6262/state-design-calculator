namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class NegativeButton : IButtons
        {
            public NegativeButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressNegative(calculator);
            }
        }
    }
    
}
