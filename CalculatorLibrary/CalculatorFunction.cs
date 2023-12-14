using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary.Buttons;

namespace Calculator
{
    public class CalculatorFunction
    {
        private readonly CalculatorProperties Calculator = new CalculatorProperties();
        private readonly Dictionary<string, IButtons> ButtonMap = new Dictionary<string, IButtons>();

        public CalculatorFunction()
        {
            // Initialize the dictionary with button tags and their corresponding button objects
            ButtonMap.Add("number", new NumberButton());
            ButtonMap.Add("add", new PlusButton());
            ButtonMap.Add("minus", new MinusButton());
            ButtonMap.Add("multiply", new MultiplyButton());
            ButtonMap.Add("divide", new DivideButton());
            ButtonMap.Add("dot", new DotButton());
            ButtonMap.Add("backspace", new BackspaceButton());
            ButtonMap.Add("CE", new ClearEntryButton());
            ButtonMap.Add("clear", new ClearButton());
            ButtonMap.Add("equal", new EqualButton());
            ButtonMap.Add("square", new SquareButton());
            ButtonMap.Add("negative", new NegativeButton());
            ButtonMap.Add("leftBracket", new LeftButton());
            ButtonMap.Add("rightBracket", new  RightButton());
        }

        /// <summary>
        /// 取得要顯示在上方的狀態列字串
        /// </summary>
        /// <returns>string</returns>
        public string GetToplabel()
        {
            return Calculator.TopText;
        }

        /// <summary>
        /// 取得要顯示在輸出欄的字串
        /// </summary>
        /// <returns>string</returns>
        public string GetOutputlabel()
        {
            return Calculator.OutputText;
        }

        /// <summary>
        /// 點擊按鈕
        /// </summary>
        /// <param name="buttonTag"></param>
        /// <param name="buttonText"></param>
        public void Press(string buttonTag, string buttonText)
        {
            ButtonMap[buttonTag].OnClick(buttonText, Calculator);
        }
    }
}
