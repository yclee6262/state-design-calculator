using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes;

namespace CalculatorWebAPI.States
{
    public class Equal : IState
    {
        public void PressBackspace(CalculatorProperties calculator)
        {
            calculator.TopText = string.Empty;
        }

        public void PressClear(CalculatorProperties calculator)
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
        }

        public void PressClearEntry(CalculatorProperties calculator)
        {
            PressClear(calculator);
        }

        public void PressDot(CalculatorProperties calculator)
        {
            calculator.CurrentString = Signs.ZERO + Signs.DotSign;
            calculator.OutputText = calculator.CurrentString;
            calculator.TopList = new List<string>();
            calculator.TopText = string.Concat(calculator.TopList);
        }

        public void PressEqual(CalculatorProperties calculator)
        {
            calculator.LastOperator.SetMultiEqual(calculator);

            calculator.LastOutput = double.Parse(calculator.OutputText);
        }

        public void PressNegative(CalculatorProperties calculator)
        {
            calculator.CurrentValue = double.Parse(calculator.OutputText) * -1;
            calculator.CurrentString = calculator.CurrentValue.ToString();
            calculator.OutputText = calculator.CurrentString;
            string negateString = calculator.LastOutput.ToString();
            calculator.LastOutput = calculator.CurrentValue;

            calculator.TopList = new List<string>
            {
                calculator.Negate(negateString),
            };

            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState = new NegativeAppend();
        }

        public void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            calculator.PostorderString = string.Empty;
            calculator.PreorderString = string.Empty;
            calculator.InorderString = string.Empty;
            calculator.TopText = string.Empty;
            calculator.TopList = new List<string>
            {
                pressedNumber,
                calculator.LastOperator.GetSymbol(),
            };

            calculator.CurrentString = $"{calculator.CurrentString}{pressedNumber}";

            double.TryParse(calculator.CurrentString, out double validValue);

            calculator.LastOutput = validValue;

            calculator.OutputText = calculator.CurrentString;
            calculator.CurrentValue = calculator.NumStack.Peek();
        }


        private void PressSquare(CalculatorProperties calculator)
        {
            calculator.PostorderString = string.Empty;
            calculator.PreorderString = string.Empty;
            calculator.InorderString = string.Empty;
            calculator.CurrentValue = Math.Sqrt(calculator.LastOutput);
            calculator.TopText = calculator.RootText(calculator.LastOutput.ToString());
            calculator.CurrentString = calculator.TopText;
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.LastOutput = calculator.CurrentValue;
            calculator.TopList = new List<string>
            {
                calculator.CurrentString,
            };
        }

        public void PressLeft(CalculatorProperties calculator)
        {
            calculator.PostfixQueue = new Queue<TreeNode>();
            calculator.PostfixQueue.Enqueue(new NumberNode(calculator.LastOutput.ToString()));
            calculator.LeftParenthesisCount = 1;
            calculator.HaveParenthesis = false;
            calculator.PostorderString = string.Empty;
            calculator.PreorderString = string.Empty;
            calculator.InorderString = string.Empty;
            calculator.TopList.Add(Signs.Left);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.OperatorStack.Push(new LeftParenthesis());
        }

        public void PressRight(CalculatorProperties calculator)
        {
            return;
        }

        public virtual void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
        {
            calculator.PostfixQueue = new Queue<TreeNode>();
            calculator.PostfixQueue.Enqueue(new NumberNode(calculator.LastOutput.ToString()));
            calculator.LeftParenthesisCount = 0;
            calculator.HaveParenthesis = false;
            calculator.PostorderString = string.Empty;
            calculator.PreorderString = string.Empty;
            calculator.InorderString = string.Empty;
            switch (pressedOperator)
            {
                case Square:
                    PressSquare(calculator); 
                    break;
                default:
                    calculator.NumStack = new Stack<double>();
                    calculator.NumStack.Push(0);
                    calculator.OperatorStack = new Stack<IOperator>();
                    calculator.OperatorStack.Push(new NoOperators());

                    calculator.CurrentValue = calculator.LastOutput;

                    calculator.CurrentString = calculator.CurrentValue.ToString();
                    calculator.TopList = new List<string>();
                    calculator.AppendOperator(calculator, pressedOperator);
                    break;
            }
        }
    }
}
