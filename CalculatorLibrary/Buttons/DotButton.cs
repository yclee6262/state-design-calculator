using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;

namespace CalculatorLibrary.Buttons
{
    public class DotButton : IButtons
    {
        public DotButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressDot(calculator);
            calculator.CurrentState = new AppendDot();
        }
    }
}
