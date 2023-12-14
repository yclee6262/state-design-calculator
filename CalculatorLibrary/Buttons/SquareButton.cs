using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;
using Calculator.States.Operators;
using CalculatorLibrary.States.Operators;

namespace CalculatorLibrary.Buttons
{
    public class SquareButton : IButtons
    {
        public SquareButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressOperator(new Square(), calculator);
            calculator.CurrentState = new AppendNumber();
            calculator.TopList = new List<string>();
        }
    }
}
