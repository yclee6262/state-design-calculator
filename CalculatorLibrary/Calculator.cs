using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Calculator.States;
using Calculator.States.Operators;

namespace Calculator
{
    public class CalculatorProperties
    {
        public double LastOutput { get; set; }
        public string LastOperatorSymbol { get; set; }

        public string CurrentString { get; set; }
        public double CurrentValue { get; set; }
        /// <summary>
        /// 存各個輸入的數字
        /// </summary>
        public Stack<double> NumStack { get; set; }

        /// <summary>
        /// 存各個輸入的運算符
        /// </summary>
        public Stack<IOperator> OperatorStack { get; set; }

        /// <summary>
        /// 顯示在結果欄的字串
        /// </summary>
        public string OutputText { get; set; }

        /// <summary>
        /// 顯示在上方狀態列的字串
        /// </summary>
        public string TopText { get; set; }
        public List<string> TopList { get; set; }
        /// <summary>
        /// 記錄計算機目前所處的狀態
        /// </summary>
        public IState CurrentState { get; set; }

        /// <summary>
        /// 存前一個運算符是什麼狀態
        /// </summary>
        public IOperator LastOperator { get; set; }

        public string Negate(string text)
        {
            return $"negate({text})";
        }

        public string RootText(string text)
        {
            return $"{Signs.RootSign}({text})";
        }

        public void PressOperator(CalculatorProperties Calculator, IOperator CurrentOperator)
        {
            while (Calculator.OperatorStack.Peek().GetPriority() >= CurrentOperator.GetPriority()) // 要先算
            {
                string preCalculation = Calculator.OperatorStack.Pop().GetAnswer(Calculator.NumStack.Pop(), Calculator.CurrentValue);
                Calculator.CurrentValue = double.Parse(preCalculation);
            }
            Calculator.OutputText = Calculator.CurrentValue.ToString();
            Calculator.NumStack.Push(Calculator.CurrentValue);
            Calculator.OperatorStack.Push(CurrentOperator);
            Calculator.LastOutput = Calculator.CurrentValue;
            Calculator.TopList.Add(Calculator.CurrentString);
            Calculator.CurrentValue = 0;
            Calculator.CurrentString = string.Empty;
        }

        public void FinalCalculation(CalculatorProperties Calculator, IOperator CurrentOperator)
        {
            double lastNumber = Calculator.NumStack.Peek();
            IOperator lastOperator = Calculator.LastOperator;
            while (Calculator.OperatorStack.Peek().GetPriority() >= CurrentOperator.GetPriority()) // 要先算
            {
                lastOperator = Calculator.OperatorStack.Peek();
                lastNumber = Calculator.CurrentValue;
                string preCalculation = Calculator.OperatorStack.Pop().GetAnswer(Calculator.NumStack.Pop(), Calculator.CurrentValue);
                Calculator.CurrentValue = double.Parse(preCalculation);
            }
            Calculator.OutputText = Calculator.CurrentValue.ToString();
            Calculator.NumStack.Push(lastNumber);
            Calculator.LastOperator = lastOperator;
            Calculator.LastOperatorSymbol = Calculator.LastOperator.GetSymbol();
            Calculator.LastOutput = Calculator.CurrentValue;
            Calculator.TopList.Add(Calculator.CurrentString);
            Calculator.CurrentValue = 0;
            Calculator.CurrentString = string.Empty;
        }

        public CalculatorProperties()
        {
            CurrentString = string.Empty;
            CurrentValue = 0;
            LastOperatorSymbol = ""; // 暫存上一個輸入的運算符號
            LastOutput = 0; // 暫存上一次的運算結果
            NumStack = new Stack<double>(); // 存使用者輸入的每一個數字
            NumStack.Push(LastOutput);
            OperatorStack = new Stack<IOperator>(); // 目前沒用到，存使用者輸入的每一個運算符
            OutputText = Signs.ZERO; // 大框的輸出
            TopText = string.Empty; // 上方小框的輸出
            TopList = new List<string>();
            CurrentState = new Initial(); // 計算機目前的狀態
            LastOperator = new NoOperators(); // 上一個輸入的運算符號，代表計算機現在要執行的計算
            OperatorStack.Push(LastOperator);
        }
    }
}
    

