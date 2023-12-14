using CalculatorWebAPI;

namespace CalculatorWebAPI
{
    public partial class CalculatorFunction
    {
        public CalculatorProperties CalculatorProperties = new();
        private interface IButtons
        {
            void Initialize(CalculatorFunction calculatorFunction);
            void OnClick(string buttonText);
        }


        private Dictionary<string, IButtons> ButtonMap = new();

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
            ButtonMap.Add("rightBracket", new RightButton());

            foreach (var buttonPair in ButtonMap)
            {
                buttonPair.Value.Initialize(this);
            }
        }

        /// <summary>
        /// 取得要顯示在上方的狀態列字串
        /// </summary>
        /// <returns>string</returns>
        public string GetToplabel()
        {
            return CalculatorProperties.TopText;
        }

        /// <summary>
        /// 取得要顯示在輸出欄的字串
        /// </summary>
        /// <returns>string</returns>
        public string GetOutputlabel()
        {
            return CalculatorProperties.OutputText;
        }

        /// <summary>
        /// 取得 postorder 字串
        /// </summary>
        /// <returns></returns>
        public string GetPostorderString()
        {
            return CalculatorProperties.PostorderString;
        }

        /// <summary>
        /// 取得 preorder 字串
        /// </summary>
        /// <returns></returns>
        public string GetPreOrderString()
        {
            return CalculatorProperties.PreorderString;
        }

        /// <summary>
        /// 取得 inorder 字串
        /// </summary>
        /// <returns></returns>
        public string GetInorderString()
        {
            return CalculatorProperties.InorderString;
        }

        /// <summary>
        /// 做出最後要回傳的字典
        /// </summary>
        /// <returns></returns>
        public CalculatorResponse GetResponse()
        {
            CalculatorResponse response = new()
            {
                TopText = GetToplabel(),
                OutputText = GetOutputlabel(),
                InorderText = GetInorderString(),
                PreorderText = GetPreOrderString(),
                PostorderText = GetPostorderString()
            };

            return response;
        }

        /// <summary>
        /// 點擊按鈕
        /// </summary>
        /// <param name="buttonTag"></param>
        /// <param name="buttonText"></param>
        public void Press(string buttonTag, string buttonText)
        {
            ButtonMap[buttonTag].OnClick(buttonText);
        }
    }
}
