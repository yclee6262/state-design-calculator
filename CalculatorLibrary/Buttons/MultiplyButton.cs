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
    public class MultiplyButton : IButtons
    {
        public MultiplyButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressOperator(new Multiply(), calculator);
            calculator.TopList.Add(Signs.MultiplySign);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState = new Calculate();
            calculator.LastOperator = new Multiply();
            calculator.OperatorNodeStack.Push(new MultiplyNode(Signs.MultiplySign));
        }
    }
}
