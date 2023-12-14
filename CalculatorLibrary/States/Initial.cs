using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary.States.Operators;

namespace Calculator.States
{
    public class Initial : AppendNumber
    {
        public override void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            base.PressNumber(pressedNumber, calculator);
            calculator.CurrentState = new AppendNumber();
        }

        public override void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
        {
            switch (pressedOperator)
            {
                case Square _:
                    PressSquare(calculator);
                    break;
                default:
                    calculator.NumStack.Push(0);
                    calculator.OperatorStack.Push(calculator.LastOperator);
                    calculator.OutputText = Signs.ZERO;
                    calculator.TopList.Add(calculator.OutputText);
                    break;
            }
            
        }

        public override void PressBackspace(CalculatorProperties calculator)
        {
            calculator.OutputText = Signs.ZERO;
        }

        public override void PressDot(CalculatorProperties calculator)
        {
            calculator.CurrentString += Signs.ZERO + Signs.DotSign;
            calculator.OutputText = calculator.CurrentString;
        }
        public override void PressNegative(CalculatorProperties calculator)
        {
            calculator.OutputText = Signs.ZERO;
        }

        public override void PressEqual(CalculatorProperties calculator)
        {
            calculator.OutputText = Signs.ZERO;
            calculator.TopList.Add(calculator.OutputText);
        }

        private void PressSquare(CalculatorProperties calculator)
        {
            calculator.CurrentString = Signs.ZERO;
            calculator.TopList.Add(calculator.RootText(calculator.CurrentString));
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentValue = Math.Sqrt(calculator.CurrentValue);
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.CurrentString = calculator.RootText(calculator.CurrentString);
            calculator.LastOutput = calculator.NumStack.Peek();
        }

        public override void PressLeft(CalculatorProperties calculator)
        {
        }
    }
}
