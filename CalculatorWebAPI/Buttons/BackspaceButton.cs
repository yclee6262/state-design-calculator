namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class BackspaceButton : IButtons
        {
            public BackspaceButton() { }

            private CalculatorFunction _calculatorFunction;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
            }

            public void OnClick(string pressedButton)
            {
                CalculatorProperties calculator = _calculatorFunction.CalculatorProperties;
                calculator.CurrentState.PressBackspace(calculator);
            }
        }
    }
    
}
