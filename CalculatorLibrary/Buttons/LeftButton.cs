using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;

namespace CalculatorLibrary.Buttons
{
    public class LeftButton : IButtons
    {
        public LeftButton() { }

        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.TopList.Add(pressedButton);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState.PressLeft(calculator);
        }
    }
}
