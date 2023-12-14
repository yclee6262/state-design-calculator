namespace CalculatorWebAPI.States
{
    public class AppendOperator : AppendNumber
    {
        public override void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
        {
            calculator.AppendOperator(calculator, pressedOperator, true);
            if (calculator.LeftParenthesisCount == 0)
            {
                calculator.HaveParenthesis = false;
            }
        }
    }
}
