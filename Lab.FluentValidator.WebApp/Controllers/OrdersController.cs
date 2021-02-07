using Lab.FluentValidator.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// reference: https://code-maze.com/deep-dive-validators-fluentvalidation/
// reference: https://code-maze.com/fluentvalidation-in-aspnet/
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab.FluentValidator.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var environmentVariable = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            return Ok("Success!");
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
