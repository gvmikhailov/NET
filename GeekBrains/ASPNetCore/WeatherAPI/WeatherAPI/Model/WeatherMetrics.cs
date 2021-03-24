using System.Collections.Generic;

namespace WeatherAPI.Model
{
    public class WeatherMetrics
    {
        public List<WeatherData> TemperatureData { get; set; }

        public WeatherMetrics()
        {
            TemperatureData = new List<WeatherData>();
        }
    }
}
