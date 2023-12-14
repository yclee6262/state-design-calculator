using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.States.Operators;
using CalculatorLibrary.States.Operators;

namespace Calculator.States
{
    public class AppendDot : IState
    {
        public void PressBackspace(CalculatorProperties calculator)
        {
            string currentString = calculator.CurrentString;
            currentString = currentString.Substring(0, Math.Max(0, currentString.Length - 1));

            double.TryParse(currentString, out double validValue);
            calculator.CurrentValue = validValue;
            calculator.CurrentString = currentString;
            calculator.OutputText = calculator.CurrentString;
            calculator.CurrentState = new AppendNumber();
        }

        public void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
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

        public void PressClearEntry(CalculatorProperties calculator)
        {
            calculator.CurrentString = string.Empty;
            calculator.CurrentValue = 0;
            calculator.OutputText = Signs.ZERO;
            calculator.CurrentState = new AppendNumber();
        }

        public void PressEqual(CalculatorProperties calculator)
        {
            calculator.CurrentString = calculator.CurrentValue.ToString();
            IOperator CurrentOperator = new EqualOperator();
            calculator.FinalCalculation(calculator, CurrentOperator);
        }

        public void PressNegative(CalculatorProperties calculator)
        {
            calculator.CurrentValue *= -1;
            calculator.CurrentString = "-" + calculator.CurrentString;
            calculator.OutputText = calculator.CurrentString;
            calculator.CurrentState = new NegativeAppend();
        }

        public void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            calculator.CurrentString = $"{calculator.CurrentString}{pressedNumber}";

            double.TryParse(calculator.CurrentString, out double validValue);
            calculator.CurrentValue = validValue;
            calculator.OutputText = calculator.CurrentString;
            calculator.CurrentState = new AppendNumber();
        }

        public void PressDot(CalculatorProperties calculator)
        {
        }

        private void PressSquare(CalculatorProperties calculator)
        {
            calculator.CurrentString = calculator.RootText(calculator.CurrentValue.ToString());
            calculator.CurrentValue = Math.Sqrt(calculator.CurrentValue);
            calculator.TopList.Add(calculator.CurrentString);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.OutputText = calculator.CurrentValue.ToString();
        }

        public void PressLeft(CalculatorProperties calculator)
        {

        }
    }
}
