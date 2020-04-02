using System;

namespace WebApplication2
{
    public class WeatherForecast
    {
        public WeatherForecast(DateTime date, int tempC, string summary) {
            Date = date;
            TemperatureC = tempC;
            Summary = summary;
        }

        public WeatherForecast()
        {
        }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
