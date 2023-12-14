using CalculatorWebAPI.States;
using CalculatorWebAPI.States.Operators;
using CalculatorWebAPI.TreeNodes;

namespace CalculatorWebAPI
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

        /// <summary>
        /// 用來存輸入的運算符號
        /// </summary>
        public Stack<OperatorNode> OperatorNodeStack { get; set; }

        /// <summary>
        /// 以 postorder 順序來存運算式的 Queue
        /// </summary>
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
        /// 用來記錄目前有幾組左括號沒有被右括號配對
        /// </summary>
        public int LeftParenthesisCount { get; set; }

        /// <summary>
        /// 前序排列的字串
        /// </summary>
        public string PreorderString { get; set; }

        /// <summary>
        /// 中序排列的字串
        /// </summary>
        public string InorderString { get; set; }

        /// <summary>
        /// 後序排列的字串
        /// </summary>
        public string PostorderString { get; set; }

        /// <summary>
        /// 輸入中是否有括號
        /// </summary>
        public bool HaveParenthesis { get; set; }

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
            return $"{Signs.SquareSign}({text})";
        }

        /// <summary>
        /// 點擊一個新的運算符號後對 OperatorNodeStack 以及 PostfixQueue 做更新
        /// </summary>
        /// <param name="calculator"></param>
        /// <param name="currentOperator"></param>
        public void UpdateOperatorNodeStack(CalculatorProperties calculator, IOperator currentOperator, bool isAfterParenthesis)
        {
            if(isAfterParenthesis is false)
            {
                calculator.PostfixQueue.Enqueue(new NumberNode(calculator.CurrentString));
                Console.WriteLine(new NumberNode(calculator.CurrentString).Value);
            }
            
            OperatorNode newNode = currentOperator.GetOperatorNode();
            
            while (true)
            {
                calculator.OperatorNodeStack.TryPeek(out OperatorNode node); // 拿目前最上面的來比

                if (node != null && node.Weight >= newNode.Weight)
                {
                    Console.WriteLine(calculator.OperatorNodeStack.Peek().Value);
                    calculator.PostfixQueue.Enqueue(calculator.OperatorNodeStack.Pop());
                }
                else
                {
                    calculator.OperatorNodeStack.Push(newNode);
                    break;
                }
            }
        }

        /// <summary>
        /// 由 prefixQueue 建立 tree
        /// </summary>
        /// <param name="calculator"></param>
        /// <returns></returns>
        public TreeNode BuildTree(CalculatorProperties calculator)
        {
            Stack<TreeNode> stack = new();

            foreach (var node in calculator.PostfixQueue)
            {
                if (node.Value == Signs.Left) // 是括號就跳過
                {
                    continue;
                }

                if (node is NumberNode || (node is OperatorNode && stack.Count >= 2)) // 數字的話就直接塞，是運算符號就看有沒有至少兩個來當子樹再塞回去
                {
                    if (node is OperatorNode operatorNode)
                    {
                        operatorNode.RightChild = stack.Pop();
                        operatorNode.LeftChild = stack.Pop();
                    }

                    stack.Push(node);
                }
            }

            stack.TryPeek(out TreeNode rootNode);
            
            return rootNode;
        }

        /// <summary>
        /// 以 preorder 的方式去遍歷整個 tree (中左右)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="calculator"></param>
        public void PreorderTraversal(TreeNode root, CalculatorProperties calculator)
        {
            if (root == null)
            {
                return;
            }

            if (root is OperatorNode operatorNode)
            {
                calculator.PreorderString += $"{operatorNode.Value} ";
            }
            else if (root is NumberNode numberNode)
            {
                calculator.PreorderString += $"{numberNode.Value} ";
            }

            PreorderTraversal(root.LeftChild, calculator);
            PreorderTraversal(root.RightChild, calculator);
        }

        /// <summary>
        /// 以 inorder 的方式去遍歷整個 tree (左中右)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="calculator"></param>
        public void InorderTraversal(TreeNode root, CalculatorProperties calculator, bool isNested = false) // 進子樹的時候會設成 true
        {
            if (root == null)
            {
                return;
            }

            if (root.LeftChild != null && isNested)
            {
                calculator.InorderString += Signs.Left;
            }

            InorderTraversal(root.LeftChild, calculator, true);

            if (root is OperatorNode operatorNode)
            {
                calculator.InorderString += $"{operatorNode.Value} ";
            }
            else if (root is NumberNode numberNode)
            {
                calculator.InorderString += $"{numberNode.Value} ";
            }

            InorderTraversal(root.RightChild, calculator, true);

            if (root.RightChild != null && isNested)
            {
                calculator.InorderString += Signs.Right;
            }
        }


        /// <summary>
        /// 以 postorder 的方式去遍歷整個 tree (左中右)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="calculator"></param>
        public void PostorderTraversal(TreeNode root, CalculatorProperties calculator)
        {
            if (root == null)
            {
                return;
            }

            PostorderTraversal(root.LeftChild, calculator);
            PostorderTraversal(root.RightChild, calculator);

            if (root is OperatorNode operatorNode)
            {
                calculator.PostorderString += $"{operatorNode.Value} ";
            }
            else if (root is NumberNode numberNode)
            {
                calculator.PostorderString += $"{numberNode.Value} ";
            }
        }

        /// <summary>
        /// 按下運算符後會對計算機進行的設定
        /// </summary>
        /// <param name="calculator"></param>
        /// <param name="currentOperator"></param>
        public void AppendOperator(CalculatorProperties calculator, IOperator currentOperator, bool isAfterParenthesis = false)
        {
            calculator.CurrentString = currentOperator.GetString(calculator.CurrentValue, calculator);

            calculator.UpdateOperatorNodeStack(calculator, currentOperator, isAfterParenthesis);
            
            while (calculator.OperatorStack.Peek().Priority >= currentOperator.Priority) // 要先算
            {
                string preCalculation = calculator.OperatorStack.Pop().GetAnswer(calculator.NumStack.Pop(), calculator.CurrentValue);
                calculator.CurrentValue = double.Parse(preCalculation);
            }

            calculator.OutputText = calculator.CurrentValue.ToString();
            calculator.NumStack.Push(calculator.CurrentValue);
            calculator.OperatorStack.Push(currentOperator);
            calculator.LastOutput = calculator.CurrentValue;

            if (calculator.TopList.LastOrDefault() != Signs.Right) // 如果前面有括號的話就不用再加數字上去了
            {
                calculator.TopList.Add(calculator.CurrentString);
            }

            // 把輸入中的數字歸零
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
            if (calculator.HaveParenthesis is false) // 如果有括號的話前面就已經把數字塞進去了
            {
                calculator.PostfixQueue.Enqueue(new NumberNode(calculator.CurrentString));
                Console.WriteLine(new NumberNode(calculator.CurrentString).Value);
            }
            
            double lastNumber = calculator.NumStack.Peek();
            IOperator lastOperator = calculator.LastOperator;

            while (calculator.OperatorNodeStack.Count != 0) // 把 OperatorNodeStack 中剩下的依序丟到 Queue 中
            {
                Console.WriteLine(calculator.OperatorNodeStack.Peek().Value);
                calculator.PostfixQueue.Enqueue(calculator.OperatorNodeStack.Pop());
            }

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

            if (calculator.TopList.LastOrDefault() != Signs.Right) // 如果前面有括號的話就不用再加數字上去了
            {
                calculator.TopList.Add(calculator.CurrentString);
            }

            calculator.CurrentValue = 0;
            calculator.CurrentString = string.Empty;

            // 開始建 tree
            TreeNode root = calculator.BuildTree(calculator);
            calculator.PreorderTraversal(root, calculator);
            calculator.InorderTraversal(root, calculator);
            calculator.PostorderTraversal(root, calculator);
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
            PostfixQueue = new Queue<TreeNode>();
            OutputText = Signs.ZERO; // 大框的輸出
            TopText = string.Empty; // 上方小框的輸出
            TopList = new List<string>();
            CurrentState = new Initial(); // 計算機目前的狀態
            LastOperator = new NoOperators(); // 上一個輸入的運算符號，代表計算機現在要執行的計算
            OperatorStack.Push(LastOperator);
            LeftParenthesisCount = 0;
            HaveParenthesis = false;
            PreorderString = string.Empty;
            InorderString = string.Empty;
            PostorderString = string.Empty;
        }
    }
}
