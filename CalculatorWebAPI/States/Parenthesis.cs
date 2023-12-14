using CalculatorWebAPI.States.Operators;

namespace CalculatorWebAPI.States
{
    public class Parenthesis : IState
    {
        public void PressBackspace(CalculatorProperties calculator)
        {
            // do nothing
        }

        public void PressClearEntry(CalculatorProperties calculator)
        {
            calculator.OutputText = Signs.ZERO;
        }

        public void PressDot(CalculatorProperties calculator)
        {
            calculator.CurrentString = $"{Signs.ZERO}{Signs.DotSign}";
            calculator.OutputText = calculator.CurrentString ;
        }

        public void PressEqual(CalculatorProperties calculator)
        {
            calculator.OperatorStack.Pop(); // pop 掉剛剛的 （
            calculator.CurrentValue = double.Parse(calculator.OutputText);
            calculator.CurrentString = calculator.OutputText;
            Console.WriteLine(calculator.CurrentString);
            IOperator CurrentOperator = new EqualOperator();
            calculator.FinalCalculation(calculator, CurrentOperator);
            calculator.TopList.Add(Signs.Right);
            calculator.TopText = string.Concat(calculator.TopList);
        }

        public void PressLeft(CalculatorProperties calculator)
        {
            calculator.OperatorStack.Push(new LeftParenthesis());
            calculator.TopList.Add(Signs.Left);
            calculator.TopText = string.Concat(calculator.TopList);
        }

        public void PressNegative(CalculatorProperties calculator)
        {
            calculator.TopList.Add(calculator.Negate(calculator.NumStack.Peek().ToString()));
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.CurrentState = new NegativeAppend();
        }

        public void PressNumber(string pressedNumber, CalculatorProperties calculator)
        {
            calculator.CurrentValue = double.Parse(pressedNumber);
            calculator.CurrentString = pressedNumber;
            calculator.OutputText = pressedNumber;
            calculator.CurrentState = new AppendNumber();
        }

        public void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
        {
        }

        public void PressRight(CalculatorProperties calculator)
        {
            calculator.OperatorStack.Pop();
            calculator.TopList.Add(calculator.NumStack.Peek().ToString());
            calculator.TopList.Add(Signs.Right);
            calculator.TopText = string.Concat(calculator.TopList);
            calculator.NumStack.Push(calculator.NumStack.Peek());
        }
    }
}
