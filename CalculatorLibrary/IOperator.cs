using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IOperator
    {
        /// <summary>
        /// 取得目前 operator 的運算優先數值
        /// 乘、除：3
        /// 加、減：2
        /// 等於：1
        /// noOperators：0
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// 根據目前的 operator 進行相對應的運算
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>string</returns>
        string GetAnswer(params double[] doubles);

        string GetString(double currentValue, CalculatorProperties calculator);

        /// <summary>
        /// 取得各 operator 的符號字串
        /// </summary>
        /// <returns>string</returns>
        string GetSymbol();

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
