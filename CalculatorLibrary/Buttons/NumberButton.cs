using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;

namespace CalculatorLibrary.Buttons
{
    public class NumberButton : IButtons
    {
        public int number;

        public NumberButton() { }
        public NumberButton(int number)
        {
            this.number = number;
        }

        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressNumber(pressedButton, calculator);
        }
    }
}
