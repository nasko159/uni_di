using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public interface IWeatherForecastService
    {
        public List<WeatherForecast> GetCast();

        public void AddCast(WeatherForecast cast);
    }
    public class WeatherForecastService : IWeatherForecastService
    {
        private List<WeatherForecast> items = new List<WeatherForecast> 
                                                { new WeatherForecast(new DateTime(), 1, "str"),
                                                  new WeatherForecast(new DateTime(), 1, "str") 
                                                };
        public List<WeatherForecast> GetCast()
        {
            return items;
        }

        public void AddCast(WeatherForecast cast) {
            items.Add(cast);
        }
    }
}
