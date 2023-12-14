using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.States;
using Calculator.States.Operators;
using CalculatorLibrary.TreeNodes;

namespace CalculatorLibrary.Buttons
{
    public class ClearButton : IButtons
    {
        public ClearButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentValue = 0;
            calculator.CurrentString = string.Empty;
            calculator.TopList = new List<string>();
            calculator.TopText = string.Empty;
            calculator.OutputText = Signs.ZERO;
            calculator.NumStack = new Stack<double>();
            calculator.LastOutput = 0;
            calculator.NumStack.Push(calculator.LastOutput);
            calculator.OperatorStack = new Stack<IOperator>();
            calculator.CurrentState = new Initial();
            calculator.LastOperator = new NoOperators();
            calculator.OperatorStack.Push(calculator.LastOperator);
            calculator.OperatorNodeStack = new Stack<OperatorNode>();
        }
    }
}
