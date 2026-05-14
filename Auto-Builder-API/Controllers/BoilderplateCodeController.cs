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

        // mongodb+srv://tronn232003_db_user:OGIajsgGJSJZtCB6@mongo-storage.jv1w2i6.mongodb.net/?appName=mongo-storage
        // retrieve params from mongodb
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
