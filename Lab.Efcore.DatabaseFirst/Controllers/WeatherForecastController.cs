using Lab.Efcore.DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Efcore.DatabaseFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //public WeatherForecastController(AppDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AppDbContext dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = dbContext.Candidates.ToList();
            var result1 = dbContext.Customers.ToList();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
