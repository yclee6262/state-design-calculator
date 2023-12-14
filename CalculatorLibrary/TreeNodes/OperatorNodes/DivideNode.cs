using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.TreeNodes.OperatorNodes
{
    public class DivideNode : OperatorNode
    {
        public DivideNode(string value) : base(value, Weights.Divide)
        {

        }
    }
}
