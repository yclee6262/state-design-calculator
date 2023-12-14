using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.States.Operators;
using CalculatorLibrary.States.Operators;
using CalculatorLibrary.TreeNodes.OperatorNodes;

namespace Calculator.States
{
    public class AppendNumber : IState
    {
        public virtual void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            calculator.CurrentString = $"{calculator.CurrentString}{pressedNumber}";

            double.TryParse(calculator.CurrentString, out double validValue);
            calculator.CurrentValue = validValue;
            calculator.OutputText = calculator.CurrentString;
        }

        public virtual void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
        {
            switch (pressedOperator)
            {
                case Square _:
                    PressSquare(calculator);
                    break;
                default:
                    calculator.AppendOperator(calculator, pressedOperator);
                    break;
            }
        }

        public virtual void PressDot(CalculatorProperties calculator)
        {
            string appendDot = $"{calculator.CurrentString}{Signs.DotSign}";

            // 用 "." 切開，只取前兩段，如果重複輸入小數點也不會取到值
            string[] splitValues = appendDot.Split(Signs.DotSign[0]);
            calculator.CurrentString = $"{splitValues[0]}{Signs.DotSign}{splitValues[1]}";
            calculator.CurrentValue = double.Parse(calculator.CurrentString);
            calculator.OutputText = calculator.CurrentString;
        }

        public virtual void PressNegative(CalculatorProperties calculator)
        {
            calculator.CurrentValue *= -1;
            calculator.CurrentString = calculator.CurrentValue.ToString();
            calculator.CurrentState = new NegativeAppend();
            calculator.OutputText = calculator.CurrentString;
        }

        public void PressClearEntry(CalculatorProperties calculator)
        {
            calculator.CurrentValue = 0;
            calculator.CurrentString = string.Empty;
            calculator.OutputText = Signs.ZERO;
        }

        public virtual void PressBackspace(CalculatorProperties calculator)
        {
            string currentString = calculator.CurrentString;
            currentString = currentString.Substring(0, Math.Max(0, currentString.Length - 1));
            
            double.TryParse(currentString, out double validValue);
            calculator.CurrentValue = validValue;
            calculator.CurrentString = currentString;
            currentString = string.IsNullOrEmpty(currentString) ? "0" : currentString;
            calculator.OutputText = currentString;
        }

        public virtual void PressEqual(CalculatorProperties calculator)
        {
            Console.WriteLine(calculator.OperatorStack.Peek().ToString());
            calculator.CurrentString = calculator.CurrentValue.ToString();
            IOperator CurrentOperator = new EqualOperator();
            calculator.FinalCalculation(calculator, CurrentOperator);
        }

        private void PressSquare(CalculatorProperties calculator)
        {
            calculator.TopList.Add(calculator.RootText(calculator.CurrentString));
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentValue = Math.Sqrt(calculator.CurrentValue);
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.CurrentString = calculator.RootText(calculator.CurrentString);
            calculator.LastOutput = calculator.NumStack.Peek();
        }

        public virtual void PressLeft(CalculatorProperties calculator)
        {
            calculator.TopList.Add(Signs.Left);
            calculator.TopText = string.Concat(calculator.TopList);
        }
    }
}
