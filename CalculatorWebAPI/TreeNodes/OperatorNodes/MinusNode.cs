using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWebAPI.TreeNodes.OperatorNodes
{
    public class MinusNode : OperatorNode
    {
        public MinusNode(string value) : base(value, Weights.Minus)
        {

        }
    }
}
