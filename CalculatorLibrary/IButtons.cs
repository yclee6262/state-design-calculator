using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IButtons
    {
        /// <summary>
        /// 按鈕的點擊
        /// </summary>
        /// <param name="pressedButton"></param>
        /// <param name="calculator"></param>
        void OnClick(string pressedButton, CalculatorProperties calculator);
    }
}
