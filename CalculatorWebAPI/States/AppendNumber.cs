using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes.OperatorNodes;
using CalculatorWebAPI.TreeNodes;

namespace CalculatorWebAPI.States
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
            while (calculator.LeftParenthesisCount > 0) // 補齊沒對應到的括號
            {
                PressRight(calculator);
            }

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
            calculator.LeftParenthesisCount += 1;
            calculator.NumStack.Push(calculator.CurrentValue);
            calculator.OperatorStack.Push(new Multiply());
            calculator.OperatorStack.Push(new LeftParenthesis());
            calculator.TopList.Add(calculator.CurrentString);
            calculator.TopList.Add(Signs.MultiplySign);
            calculator.TopList.Add(Signs.Left);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.UpdateOperatorNodeStack(calculator, new Multiply(), false);
            calculator.OperatorNodeStack.Push(new LeftParenthesisNode(Signs.Left));
        }

        public void PressRight(CalculatorProperties calculator)
        {
            calculator.HaveParenthesis = true;
            if (calculator.LeftParenthesisCount == 0) // 前面沒輸入過括號，按右括號沒有用或是已經補齊了
            {
                return;
            }
            else
            {
                calculator.LeftParenthesisCount -= 1;
                if (calculator.TopList.LastOrDefault() != Signs.Right) // 如果前面有括號的話就不用再加數字上去了
                {
                    calculator.TopList.Add(calculator.CurrentString);
                    calculator.PostfixQueue.Enqueue(new NumberNode(calculator.CurrentString));
                    Console.WriteLine(new NumberNode(calculator.CurrentString).Value);
                }
                
                calculator.TopList.Add(Signs.Right);
                calculator.TopText = string.Concat(calculator.TopList);

                while (calculator.OperatorStack.Peek().Priority >= 1) // 要先算，算到遇到左括號為止(左括號的 priority 為 0)
                {
                    string preCalculation = calculator.OperatorStack.Pop().GetAnswer(calculator.NumStack.Pop(), calculator.CurrentValue);
                    calculator.CurrentValue = double.Parse(preCalculation);
                }

                for (int i = 0; i < calculator.OperatorNodeStack.Count; i++)
                {
                    var item = calculator.OperatorNodeStack.Peek();

                    if (item.Weight > 0) // 左括號的 weight 是 0，所以在遇到左括號之前把 stack 中的東西都塞到 queue 中
                    {
                        Console.WriteLine(calculator.OperatorNodeStack.Peek().Value);
                        calculator.PostfixQueue.Enqueue(calculator.OperatorNodeStack.Pop());
                    }
                    else
                    {
                        Console.WriteLine("( poped");
                        calculator.OperatorNodeStack.Pop();
                        Console.WriteLine(calculator.OperatorNodeStack.Count);
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
