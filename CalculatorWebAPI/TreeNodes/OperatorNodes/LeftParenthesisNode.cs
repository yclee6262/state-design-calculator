namespace CalculatorWebAPI.TreeNodes.OperatorNodes
{
    public class LeftParenthesisNode : OperatorNode
    {
        public LeftParenthesisNode(string value) : base(value, Weights.LeftParenthesis)
        {

        }
    }
}
