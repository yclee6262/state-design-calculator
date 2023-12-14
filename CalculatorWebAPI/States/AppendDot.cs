using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI.States
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
            while (calculator.LeftParenthesisCount > 0)
            {
                PressRight(calculator);
            }
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
            calculator.LeftParenthesisCount += 1;
            calculator.NumStack.Push(calculator.CurrentValue);
            calculator.OperatorStack.Push(new Multiply());
            calculator.OperatorStack.Push(new LeftParenthesis());
            calculator.TopList.Add(calculator.CurrentValue.ToString());
            calculator.TopList.Add(Signs.MultiplySign);
            calculator.TopList.Add(Signs.Left);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.CurrentString = calculator.CurrentValue.ToString();
            calculator.UpdateOperatorNodeStack(calculator, new Multiply(), false);
            calculator.CurrentString = string.Empty;
            calculator.CurrentValue = 0;
            calculator.OperatorNodeStack.Push(new LeftParenthesisNode(Signs.Left));
        }

        public void PressRight(CalculatorProperties calculator)
        {
            calculator.HaveParenthesis = true;
            if (calculator.LeftParenthesisCount == 0) // 前面沒輸入過括號，按右括號沒有用
            {
                return;
            }
            else
            {
                calculator.LeftParenthesisCount -= 1;
                calculator.CurrentString = calculator.CurrentValue.ToString();
                if (calculator.TopList.LastOrDefault() != Signs.Right) // 如果前面有括號的話就不用再加數字上去了
                {
                    calculator.TopList.Add(calculator.CurrentString);
                    calculator.PostfixQueue.Enqueue(new NumberNode(calculator.CurrentString));
                }
                
                calculator.TopList.Add(Signs.Right);
                calculator.TopText = string.Concat(calculator.TopList);

                while (calculator.OperatorStack.Peek().Priority >= 1) // 要先算
                {
                    string preCalculation = calculator.OperatorStack.Pop().GetAnswer(calculator.NumStack.Pop(), calculator.CurrentValue);
                    calculator.CurrentValue = double.Parse(preCalculation);
                }

                for (int i = 0; i < calculator.OperatorNodeStack.Count; i++)
                {
                    var item = calculator.OperatorNodeStack.Peek();

                    if (item.Weight > 0) // 左括號的 weight 是 0，所以在遇到左括號之前把 stack 中的東西都塞到 queue 中
                    {
                        calculator.PostfixQueue.Enqueue(calculator.OperatorNodeStack.Pop());
                    }
                    else
                    {
                        calculator.OperatorNodeStack.Pop();
                        break;
                    }
                }

                calculator.CurrentString = calculator.CurrentValue.ToString();
                calculator.OutputText = calculator.CurrentString;
                calculator.OperatorStack.Pop();
            }
        }
    }
}
