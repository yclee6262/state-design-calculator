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
    public class MinusButton : IButtons
    {
        public MinusButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressOperator(new Minus(), calculator);
            calculator.TopList.Add(Signs.MinusSign);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState = new Calculate();
            calculator.LastOperator = new Minus();
            calculator.OperatorNodeStack.Push(new MinusNode(Signs.MinusSign));
        }
    }
}
