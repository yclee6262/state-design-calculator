using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Calculator.States;
using Calculator.States.Operators;
using CalculatorLibrary;
using CalculatorLibrary.TreeNodes;

namespace Calculator
{
    public class CalculatorProperties
    {
        /// <summary>
        /// 用來記錄上一次的運算結果
        /// </summary>
        public double LastOutput { get; set; }

        /// <summary>
        /// 目前輸入的值
        /// </summary>
        public string CurrentString { get; set; }

        /// <summary>
        /// 目前輸入的值
        /// </summary>
        public double CurrentValue { get; set; }

        /// <summary>
        /// 存各個輸入的數字
        /// </summary>
        public Stack<double> NumStack { get; set; }

        /// <summary>
        /// 存各個輸入的運算符
        /// </summary>
        public Stack<IOperator> OperatorStack { get; set; }

        public Stack<OperatorNode> OperatorNodeStack { get; set; }

        public Queue<TreeNode> PostfixQueue { get; set; }

        /// <summary>
        /// 顯示在結果欄的字串
        /// </summary>
        public string OutputText { get; set; }

        /// <summary>
        /// 顯示在上方狀態列的字串
        /// </summary>
        public string TopText { get; set; }

        /// <summary>
        /// 用來做出 TopText 的 List
        /// </summary>
        public List<string> TopList { get; set; }

        /// <summary>
        /// 記錄計算機目前所處的狀態
        /// </summary>
        public IState CurrentState { get; set; }

        /// <summary>
        /// 存前一個運算符是什麼狀態
        /// </summary>
        public IOperator LastOperator { get; set; }

        /// <summary>
        /// 產生 negate 字串
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string</returns>
        public string Negate(string text)
        {
            return $"negate({text})";
        }

        /// <summary>
        /// 產生帶有根號符號的字串
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string</returns>
        public string RootText(string text)
        {
            return $"{Signs.RootSign}({text})";
        }

        /// <summary>
        /// 按下運算符後會對計算機進行的設定
        /// </summary>
        /// <param name="calculator"></param>
        /// <param name="currentOperator"></param>
        public void AppendOperator(CalculatorProperties calculator, IOperator currentOperator)
        {
            calculator.CurrentString = currentOperator.GetString(calculator.CurrentValue, calculator);
            while (calculator.OperatorStack.Peek().Priority >= currentOperator.Priority) // 要先算
            {
                string preCalculation = calculator.OperatorStack.Pop().GetAnswer(calculator.NumStack.Pop(), calculator.CurrentValue);
                calculator.CurrentValue = double.Parse(preCalculation);
            }
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.NumStack.Push(calculator.CurrentValue);
            calculator.OperatorStack.Push(currentOperator);
            calculator.LastOutput = calculator.CurrentValue;
            calculator.TopList.Add(calculator.CurrentString);
            calculator.CurrentValue = 0;
            calculator.CurrentString = string.Empty;
        }

        /// <summary>
        /// 按下等號會對計算機進行的動作
        /// </summary>
        /// <param name="calculator"></param>
        /// <param name="currentOperator"></param>
        public void FinalCalculation(CalculatorProperties calculator, IOperator currentOperator)
        {
            double lastNumber = calculator.NumStack.Peek();
            IOperator lastOperator = calculator.LastOperator;
            while (calculator.OperatorStack.Peek().Priority >= currentOperator.Priority) // 要先算
            {
                lastOperator = calculator.OperatorStack.Peek();
                lastNumber = calculator.CurrentValue;
                string preCalculation = calculator.OperatorStack.Pop().GetAnswer(calculator.NumStack.Pop(), calculator.CurrentValue);
                calculator.CurrentValue = double.Parse(preCalculation);
            }
            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.NumStack.Push(lastNumber);
            calculator.LastOperator = lastOperator;
            calculator.LastOutput = calculator.CurrentValue;
            calculator.TopList.Add(calculator.CurrentString);
            calculator.CurrentValue = 0;
            calculator.CurrentString = string.Empty;
        }

        public CalculatorProperties()
        {
            CurrentString = string.Empty;
            CurrentValue = 0;
            LastOutput = 0; // 暫存上一次的運算結果
            NumStack = new Stack<double>(); // 存使用者輸入的每一個數字
            NumStack.Push(LastOutput);
            OperatorStack = new Stack<IOperator>(); // 存使用者輸入的每一個運算符
            OperatorNodeStack = new Stack<OperatorNode>();
            OutputText = Signs.ZERO; // 大框的輸出
            TopText = string.Empty; // 上方小框的輸出
            TopList = new List<string>();
            CurrentState = new Initial(); // 計算機目前的狀態
            LastOperator = new NoOperators(); // 上一個輸入的運算符號，代表計算機現在要執行的計算
            OperatorStack.Push(LastOperator);
        }
    }
}
    

