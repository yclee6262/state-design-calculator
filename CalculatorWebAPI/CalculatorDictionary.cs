using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace CalculatorWebAPI
{
    /// <summary>
    /// 用來存不同 calculator 的字典
    /// </summary>
    public static class CalculatorDictionary
    {
        private static readonly ConcurrentDictionary<string, CalculatorFunction> _calculatorData = new();

        static CalculatorDictionary()
        {
            CalculatorData = _calculatorData;
        }

        public static ConcurrentDictionary<string, CalculatorFunction> CalculatorData { get; }
    }
}
