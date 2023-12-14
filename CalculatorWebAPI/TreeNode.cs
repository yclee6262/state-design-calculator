namespace CalculatorWebAPI
{
    public abstract class TreeNode
    {
        public string Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(string value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
