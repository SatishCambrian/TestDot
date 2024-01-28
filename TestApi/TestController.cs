using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public string TestMethod(string param="World!")
        {
            return String.Concat("Hello",param) ;
        }

        public string Get()
        {
            return "Get Method";
        }
    }
}
