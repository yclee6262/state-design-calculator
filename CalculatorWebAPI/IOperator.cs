using CalculatorWebAPI.TreeNodes;

namespace CalculatorWebAPI
{
    public interface IOperator
    {
        /// <summary>
        /// 取得目前 operator 的運算優先數值
        /// 乘、除：3
        /// 加、減：2
        /// 等於：1
        /// 左括號、noOperators：0
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// 根據目前的 operator 進行相對應的運算
        /// </summary>
        /// <param name="doubles"></param>
        /// <returns>string</returns>
        string GetAnswer(params double[] doubles);

        string GetString(double currentValue, CalculatorProperties calculator);

        /// <summary>
        /// 取得各 operator 的符號字串
        /// </summary>
        /// <returns>string</returns>
        string GetSymbol();

        /// <summary>
        /// 取得各 operator 所對應的 OperatorNode
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        OperatorNode GetOperatorNode();

        /// <summary>
        /// 連續等於時需用來產生 TopList
        /// </summary>
        /// <param name="calculator"></param>
        void SetMultiEqual(CalculatorProperties calculator);

        /// <summary>
        /// 負號接等號時需產生不同 TopList
        /// </summary>
        /// <param name="calculator"></param>
        void SetNegativeEqual(CalculatorProperties calculator);
    }
}
