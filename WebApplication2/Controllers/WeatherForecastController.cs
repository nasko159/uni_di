using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private IWeatherForecastService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
                                         IWeatherForecastService service)
        {
            _logger = logger;
            _weatherService = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetCasts()
        {
            return _weatherService.GetCast();
        }

        [HttpPost]
        public void Post(WeatherForecast cast)
        {
            _weatherService.AddCast(cast);
        }
    }
}
