using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Model;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private WeatherMetrics _holder;

        public TemperatureController(WeatherMetrics holder)
        {
            _holder = holder;
        }

        [HttpGet("read")]
        public IEnumerable<WeatherData> Get([FromBody] DateScope scope)
        {
            return _holder.TemperatureData.Where(i => i.Date >= scope.DateFrom && i.Date <= scope.DateTo).ToArray();
        }

        [HttpPost("set")]
        public IActionResult Set([FromBody] WeatherData data)
        {
            if (!_holder.TemperatureData.Contains(data))
            {
                _holder.TemperatureData.Add(data);
                return OK();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] WeatherData data)
        {
            if (_holder.TemperatureData.Contains(data))
            {
                int elem = _holder.TemperatureData.IndexOf(data);
                _holder.TemperatureData[elem].Date = data.Date;
                _holder.TemperatureData[elem].Temperature = data.Temperature;
                return OK();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("delete")]
        public string Delete([FromBody] DateScope scope)
        {
            List<WeatherData> toDelete = _holder.TemperatureData.Where(i => i.Date >= scope.DateFrom && i.Date <= scope.DateTo).ToList();
            foreach (var t in toDelete)
            {
                _holder.TemperatureData.Remove(t);
            }
            return OK();
        }
    }
}
