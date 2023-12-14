using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.States;
using Calculator;

namespace CalculatorLibrary.Buttons
{
    public class BackspaceButton : IButtons
    {
        public BackspaceButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressBackspace(calculator);
        }
    }
}
