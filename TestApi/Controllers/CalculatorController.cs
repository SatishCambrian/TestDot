using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public string Add(decimal num1, decimal num2)
        {
            // String Interpolation
            return $"Sum of {num1} and {num2} is {num1+num2}.";
        }
        public string Sub(decimal num1, decimal num2)
        {
            return $"Subraction between {num1} and {num2} is {num1-num2}.";
        }

        public string Sub(decimal num1, decimal num2)
        {
            return $"Subraction between {num1} and {num2} is {num1-num2}.";
        }
        public string Get()
        {
            return "Get Method";
        }
    }
}
