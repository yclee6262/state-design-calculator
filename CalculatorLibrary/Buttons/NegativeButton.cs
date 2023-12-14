using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;

namespace CalculatorLibrary.Buttons
{
    public class NegativeButton : IButtons
    {
        public NegativeButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressNegative(calculator);
        }
    }
}
