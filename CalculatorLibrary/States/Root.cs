//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Calculator.States.Operators;

//namespace Calculator.States
//{
//    public class Root : AppendNumber
//    {
//        public override void PressEqual(CalculatorProperties calculator)
//        {
//            calculator.CurrentString = string.Empty;
//            IOperator CurrentOperator = new EqualOperator();
//            calculator.FinalCalculation(calculator, CurrentOperator);
//        }

//        public override void PressOperator(IOperator pressedOperator, CalculatorProperties calculator)
//        {
//            calculator.CurrentString = string.Empty;
//            base.PressOperator(pressedOperator, calculator);
//        }

//        public override void PressSquare(CalculatorProperties calculator)
//        {
//            calculator.CurrentString = calculator.RootText(calculator.CurrentString);
//            calculator.TopList[calculator.TopList.Count - 1] = calculator.CurrentString;
//            calculator.TopText = string.Concat(calculator.TopList);
//            calculator.CurrentValue = Math.Sqrt(calculator.CurrentValue);
//            calculator.OutputText = calculator.CurrentValue.ToString();
//        }
//    }
//}
