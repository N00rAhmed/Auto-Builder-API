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

            var template = Template.Parse(@"
<ul id='products'>
    <li>
      <h2>Hello World</h2>
            NIOFERNIERONFER


    </li>
</ul>

Helloo


WORLDDD

");
            //var result = template.Render(template);
            // var result = template.Render(new { Products = this.ProductList });
            //var result = template.Render(new { Name = "World" });
            //var result = template.Render(template);
            var result = template.Render();

            return Content(result);

            //return Content("Hello World");
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
        
        }

        // mongodb+srv://tronn232003_db_user:OGIajsgGJSJZtCB6@mongo-storage.jv1w2i6.mongodb.net/?appName=mongo-storage
        // retrieve data from mongodb
        [HttpGet("mongo-params")]
        public ActionResult GetMongoParams(string uri)
        {
            return Ok();
        }

        // use traditional GET request first to see how to fetch data from mongo using ASP.NET
        [HttpGet("mongo-content")]
        public ActionResult GetMongoContent()
        {
            return Ok();
        }


        [HttpGet("addition")]
        public ActionResult GetSum(int num1, int num2)
        {
            int result = num1 + num2;
            //return Ok(new { result });
            //return product == null ? NotFound() : Ok(product);
            return Ok(result);
        }

        [HttpGet("fastapi-example")]
        public ActionResult FastAPI()
        {

            var template = Template.Parse(
                """
                from fastapi import FastAPI

                app = FastAPI()

                @app.get("/")
                def read_root():
                    return {"Hello": "World"}
                """
                );


            var result = template.Render();
            return Content(result);

        }


    }
}
