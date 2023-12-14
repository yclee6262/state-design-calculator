using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;

namespace CalculatorLibrary.Buttons
{
    public class EqualButton : IButtons
    {
        public EqualButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressEqual(calculator);
            calculator.TopList.Add(Signs.EqualSign);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.TopList = new List<string>();
            calculator.CurrentValue = 0;
            calculator.CurrentString = string.Empty;
            calculator.CurrentState = new Equal();
        }
    }
}
