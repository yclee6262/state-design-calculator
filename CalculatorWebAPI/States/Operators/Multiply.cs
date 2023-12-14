using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorWebAPI.TreeNodes;
using CalculatorWebAPI.TreeNodes.OperatorNodes;

namespace CalculatorWebAPI.States.Operators
{
    public class Multiply : IOperator
    {
        public int Priority { get => 3; }

        public string GetAnswer(double[] doubles)
        {
            return (doubles[0] * doubles[1]).ToString();
        }

        public string GetString(double currentNumber, CalculatorProperties calculator)
        {
            return currentNumber.ToString();
        }

        public string GetSymbol()
        {
            return Signs.MultiplySign;
        }

        public OperatorNode GetOperatorNode()
        {
            return new MultiplyNode(Signs.MultiplySign);
        }

        public void SetMultiEqual(CalculatorProperties calculator)
        {
            calculator.PostorderString = string.Empty;
            calculator.PreorderString = string.Empty;
            calculator.InorderString = string.Empty;

            calculator.TopList = new List<string>
            {
                calculator.LastOutput.ToString(),
                calculator.LastOperator.GetSymbol(),
             };

            calculator.CurrentValue = calculator.NumStack.Pop();
            calculator.CurrentString = calculator.CurrentValue.ToString();
            calculator.NumStack.Push(calculator.LastOutput);

            calculator.PostfixQueue.Enqueue(new NumberNode(calculator.CurrentString));
            Console.WriteLine(new NumberNode(calculator.CurrentString).Value);
            calculator.PostfixQueue.Enqueue(new NumberNode(calculator.NumStack.Peek().ToString()));
            Console.WriteLine(new NumberNode(calculator.NumStack.Peek().ToString()).Value);
            calculator.OperatorNodeStack.Push(GetOperatorNode());
            calculator.OperatorStack.Push(new Multiply());

            IOperator CurrentOperator = new EqualOperator();
            calculator.FinalCalculation(calculator, CurrentOperator);
        }

        public void SetNegativeEqual(CalculatorProperties calculator)
        {
            calculator.TopList.Add(calculator.CurrentString);
        }
    }
}

