using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Scriban;

namespace Auto_Builder_API.Controllers
{
    [ApiController]

    // route "controller sets base endpoint as /WeatherForecast removing controller by default"
    [Route("[controller]")]
    public class BoilderplateCodeController : ControllerBase
    {

        [HttpGet("hello-world")]
        public ActionResult GetHello() { 
            return Content("Hello World");
        }

        [HttpGet("age")]
        public ActionResult GetAge(int age)
        {
            return Content("you are " + $"{age} years old");
        }

        [HttpGet("template-engine/scriban")]
        public ActionResult GetTemplateCode()
        {
            // Parse a scriban template
            var template = Template.Parse("print('{{message}}')");
            var result = template.Render(new { Message = "hello world!" }); // => print('hello world!')

            return Content(result);
//            return Content("wtf");
        }

    }
}
