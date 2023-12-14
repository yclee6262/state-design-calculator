using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.TreeNodes
{
    public abstract class OperatorNode : TreeNode
    {
        public int Weight { get; set; }

        public OperatorNode(string value,  int weight) : base(value)
        {
            Weight = weight;
        }
    }
}
