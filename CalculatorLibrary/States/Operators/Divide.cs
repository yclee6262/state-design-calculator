using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.States.Operators
{
    public class Divide : IOperator
    {
        public string GetAnswer(double[] doubles)
        {
            return (doubles[0] / doubles[1]).ToString();
        }

        public string GetString(double currentNumber, CalculatorProperties calculator)
        {
            return currentNumber.ToString();
        }

        public int Priority { get => 3; }

        public string GetSymbol()
        {
            return Signs.DivideSign;
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
            string tempAnswer = calculator.LastOperator.GetAnswer(calculator.LastOutput, calculator.NumStack.Peek());

            calculator.TopList = new List<string>
                {
                    calculator.LastOutput.ToString(),
                    calculator.LastOperator.GetSymbol(),
                    calculator.NumStack.Peek().ToString(),
                };
            calculator.OutputText = tempAnswer;
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
            calculator.TopList.Add(calculator.CurrentString);
        }
    }
}
