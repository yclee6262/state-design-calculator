using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IState
    {
        /// <summary>
        /// 點擊數字鍵會進行的操作
        /// </summary>
        /// <param name="pressedNumber"></param>
        /// <param name="calculator"></param>
        void PressNumber(string pressedNumber, CalculatorProperties calculator);

        void PressOperator(IOperator pressedOperator, CalculatorProperties calculator);

        /// <summary>
        /// 點擊小數點會進行的操作
        /// </summary>
        /// <param name="calculator"></param>
        void PressDot(CalculatorProperties calculator);

        /// <summary>
        /// 點擊正負號會進行的操作
        /// </summary>
        /// <param name="calculator"></param>
        void PressNegative (CalculatorProperties calculator);

        /// <summary>
        /// 點擊 CE 鍵會進行的操作
        /// </summary>
        /// <param name="calculator"></param>
        void PressClearEntry(CalculatorProperties calculator);

        /// <summary>
        /// 點擊 backspace 會進行的操作
        /// </summary>
        /// <param name="calculator"></param>
        void PressBackspace(CalculatorProperties calculator);

        /// <summary>
        /// 點擊等號會進行的操作
        /// </summary>
        /// <param name="calculator"></param>
        void PressEqual(CalculatorProperties calculator);

        /// <summary>
        /// 點擊根號鍵會進行的操作
        /// </summary>
        /// <param name="calculator"></param>
        //void PressSquare(CalculatorProperties calculator);

        void PressLeft(CalculatorProperties calculator);
    }
}
