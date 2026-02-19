using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Auto_Builder_API.Controllers
{
    [ApiController]

    // route "controller sets base endpoint as /WeatherForecast removing controller by default"
    [Route("[controller]")]
    public class TemplateController : ControllerBase
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

        [HttpGet("template-engine")]
        public ActionResult GetTemplateCode()
        {
            return Content("wtf");
        }

    }
}
