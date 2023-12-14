using CalculatorWebAPI.States.Operators;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CalculatorControler : Controller
    {
        /// <summary>
        /// 創建新的計算機會對應的 API
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("create")]
        public ObjectResult CreateCalculator()
        {
            Console.WriteLine("create new calculator");
            CalculatorFunction newCalculator = new();

            string randomID = Guid.NewGuid().ToString();
            if (CalculatorDictionary.CalculatorData.TryAdd(randomID, newCalculator) is false)
            {
                return BadRequest("Unable to create new calculator.");
            }
            Console.WriteLine(randomID);
            return Ok(randomID);
        }

        /// <summary>
        /// 點擊按鈕會對應到的 API
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        /// <returns>Dictionary</returns>
        [HttpPost]
        [Route("{id}/press")]
        public CalculatorResponse Press(string id, string tag, string value)
        {
            CalculatorFunction calculatorObject = CalculatorDictionary.CalculatorData[id];
            calculatorObject.Press(tag, value);
            //calculatorObject.ButtonMap[tag].OnClick(value, calculatorObject.CalculatorProperties);

            return calculatorObject.GetResponse();
        }
    }
    
}
