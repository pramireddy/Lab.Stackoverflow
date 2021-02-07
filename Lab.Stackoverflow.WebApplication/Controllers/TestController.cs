using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab.Stackoverflow.WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<CDTO> Get()
        {
            var cdto = new List<CDTO>
            {
                new CDTO
                {
                    name = "Test Name",
                   descrption = " Test Descption"
                    //data = new List<string>{"test1","test2"}
                }
            };
            return cdto;
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromForm][FromBody] CDTO data)
        {
            var absoluteUrl = HttpContext.Request.PathBase;
            string requestUrl = $"{Request.Scheme}://{Request.Host.Value}{Request.Path}";
            //var t = Url.Content("~/");
            var request = data;

        // PUT api/<TestController>/5
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
