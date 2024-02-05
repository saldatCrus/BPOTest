using BPOTest.Servises.Exeption;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BPOTest.Controllers
{
    [Route("api/calc")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="AppException"></exception>
        [HttpGet("Calculate")]
        public async Task<double> Calculate(string expression)
        {
            try
            {
                return Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
            }
            catch
            {
                throw new AppException("Некорректное выражение");
            }
        }

        /// <summary>
        /// возведение в степень
        /// </summary>
        /// <param name="baseNumber"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        [HttpGet("Pow")]
        public async Task<double> Pow(double baseNumber, double exponent)
        {

            return Math.Pow(baseNumber, exponent);
        }

        /// <summary>
        /// Возвращает квадратный корень из указанного числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpGet("Sqrt")]
        public async Task<double> Sqrt(double number) 
        {
            return Math.Sqrt(number);
        }
    }

}
