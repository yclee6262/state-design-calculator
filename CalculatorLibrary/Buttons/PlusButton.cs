using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;
using Calculator.States.Operators;
using CalculatorLibrary.TreeNodes.OperatorNodes;

namespace CalculatorLibrary.Buttons
{
    public class PlusButton : IButtons
    {
        public PlusButton() { }

        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressOperator(new Plus(), calculator);
            calculator.TopList.Add(Signs.PlusSign);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState = new Calculate();
            calculator.LastOperator = new Plus();
            calculator.OperatorNodeStack.Push(new PlusNode(Signs.PlusSign));
        }
    }
}
