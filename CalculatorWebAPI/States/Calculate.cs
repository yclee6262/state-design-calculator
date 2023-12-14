using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI.States
{
    public class Calculate : IState
    {
        public void PressBackspace(CalculatorProperties calculator)
        {
            calculator.OutputText = calculator.OutputText;
        }
        
        public void PressClearEntry(CalculatorProperties calculator)
        {
            calculator.OutputText = Signs.ZERO;
        }

        public virtual void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
        {
            switch (pressedOperator)
            {
                case Square: // 用前一個數字開根號做運算
                    PressSquare(calculator);
                    break;
                default: // 單純運算子撤換
                    calculator.OperatorStack.Pop();
                    calculator.OperatorStack.Push(pressedOperator);
                    calculator.TopList.RemoveAt(calculator.TopList.Count - 1);
                    calculator.OperatorNodeStack.Pop();
                    break;
            }
        }

        public void PressDot(CalculatorProperties calculator)
        {
            calculator.CurrentValue = 0;
            calculator.CurrentString = $"{Signs.ZERO}{Signs.DotSign}";
            calculator.OutputText = Signs.ZERO + Signs.DotSign;
        }

        public void PressEqual(CalculatorProperties calculator)
        {
            calculator.CurrentValue = calculator.NumStack.Peek();
            calculator.CurrentString = calculator.CurrentValue.ToString();
            IOperator CurrentOperator = new EqualOperator();
            calculator.FinalCalculation(calculator, CurrentOperator);
        }
        
        public void PressNegative(CalculatorProperties calculator)
        {
            calculator.CurrentValue = calculator.LastOutput * -1;
            string negateString = calculator.Negate(calculator.LastOutput.ToString());
            calculator.CurrentString = negateString;
            //calculator.TopList.Add(negateString);
            //calculator.TopText = string.Concat(calculator.TopList);
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.CurrentState = new NegativeAppend();
        }

        public void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            calculator.CurrentString = pressedNumber;

            double.TryParse(calculator.CurrentString, out double validValue);

            calculator.CurrentValue = validValue;
            calculator.OutputText = calculator.CurrentString;
            calculator.CurrentState = new AppendNumber();
        }

        private void PressSquare(CalculatorProperties calculator)
        {
            calculator.TopList.Add(calculator.RootText(calculator.NumStack.Peek().ToString()));
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentValue = Math.Sqrt(calculator.NumStack.Peek());

            calculator.CurrentString = calculator.CurrentValue.ToString();

            calculator.OutputText = calculator.CurrentString;
        }

        public void PressLeft(CalculatorProperties calculator)
        {
            calculator.LeftParenthesisCount += 1;
            calculator.OperatorStack.Push(new LeftParenthesis());
            calculator.TopList.Add(Signs.Left);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentString = string.Empty;
            calculator.CurrentValue = 0;
            calculator.OperatorNodeStack.Push(new LeftParenthesisNode(Signs.Left));
            calculator.CurrentState = new Parenthesis();
        }

        public void PressRight(CalculatorProperties calculator)
        {
            return;
        }
    }
}
