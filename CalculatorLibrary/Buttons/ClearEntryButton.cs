using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorLibrary.Buttons
{
    public class ClearEntryButton : IButtons
    {
        public ClearEntryButton() { }
        public void OnClick(string pressedButton, CalculatorProperties calculator)
        {
            calculator.CurrentState.PressClearEntry(calculator);
        }
    }
}
