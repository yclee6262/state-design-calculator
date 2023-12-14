using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.States.Operators
{
    public class NoOperators : IOperator
    {
        public int Priority { get => 0; }

        public string GetAnswer(double[] doubles)
        {
            return doubles[0].ToString();
        }

        public string GetString(double currentNumber, CalculatorProperties calculator)
        {
            return currentNumber.ToString();
        }

        public string GetSymbol()
        {
            return "";
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
            calculator.TopList = new List<string>
            {
                calculator.LastOutput.ToString(),
            };
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
            calculator.TopList = new List<string> // 讓他在點擊等於鍵時就直接顯示出來
            {
                calculator.CurrentString,
            };
        }
    }
}
