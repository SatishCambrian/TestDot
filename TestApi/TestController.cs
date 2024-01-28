using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public string TestMethod()
        {
            return "Testing0";
        }

        public string Get()
        {
            return "Get Method";
        }
    }
}
