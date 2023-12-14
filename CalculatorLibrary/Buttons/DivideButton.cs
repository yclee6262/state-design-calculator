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
    public class DivideButton : IButtons
    {
        public DivideButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressOperator(new Divide(), calculator);
            calculator.TopList.Add(Signs.DivideSign);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState = new Calculate();
            calculator.LastOperator = new Divide();
            calculator.OperatorNodeStack.Push(new DivideNode(Signs.DivideSign));
        }
    }
}
