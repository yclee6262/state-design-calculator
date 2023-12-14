namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        private class NumberButton : IButtons
        {
            public int number;

            public NumberButton() { }
            public NumberButton(int number)
            {
                this.number = number;
            }

            private CalculatorFunction _calculatorFunction;
            private CalculatorProperties _calculatorProperties;

            public void Initialize(CalculatorFunction calculatorFunction)
            {
                _calculatorFunction = calculatorFunction;
                _calculatorProperties = calculatorFunction.CalculatorProperties;
            }


            public void OnClick(string pressedButton)
            {
                _calculatorProperties.CurrentState.PressNumber(pressedButton, _calculatorProperties);
            }
        }
    }
    
}
