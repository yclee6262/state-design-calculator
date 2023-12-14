using CalculatorWebAPI.States.Operators;

namespace CalculatorWebAPI.States
{
    public class NegativeAppend : AppendNumber
    {
        public override void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            calculator.TopList.RemoveAt(calculator.TopList.Count - 1);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentString = pressedNumber;
            calculator.OutputText = calculator.CurrentString;
            calculator.CurrentValue = double.Parse(calculator.CurrentString);
            calculator.CurrentState = new AppendNumber();
        }

        public override void PressNegative(CalculatorProperties calculator)
        {
            calculator.CurrentValue *= -1;
            calculator.CurrentString = calculator.Negate(calculator.CurrentString);
            calculator.OutputText = calculator.CurrentValue.ToString();
            if (calculator.TopList.Count > 0)
            {
                calculator.TopList[calculator.TopList.Count - 1] = calculator.Negate(calculator.TopList[calculator.TopList.Count - 1]);
                calculator.TopText = string.Concat(calculator.TopList);
            }
            else
            {
                calculator.TopText = string.Empty;
                calculator.CurrentString = calculator.OutputText;
            }
        }

        public override void PressDot(CalculatorProperties calculator)
        {
            string appendDot = $"{calculator.CurrentString}{Signs.DotSign}";

            // 用 "." 切開，只取前兩段，如果重複輸入小數點也不會取到值
            string[] splitValues = appendDot.Split(Signs.DotSign[0]);
            calculator.CurrentString = $"{splitValues[0]}{Signs.DotSign}{splitValues[1]}";
            calculator.CurrentValue = double.Parse(calculator.CurrentString);


            calculator.OutputText = calculator.CurrentString;
        }

        public override void PressEqual(CalculatorProperties calculator)
        {
            while (calculator.LeftParenthesisCount > 0)
            {
                PressRight(calculator);
            }
            calculator.CurrentString = calculator.CurrentValue.ToString();

            calculator.LastOperator.SetNegativeEqual(calculator);

            calculator.CurrentString = string.Empty; // 顯示過了所以要清空，避免重複輸出
            IOperator CurrentOperator = new EqualOperator();
            calculator.FinalCalculation(calculator, CurrentOperator);
        }
    }
}
