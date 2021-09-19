using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bethselamin.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries =
        {
            "Solsbury Hill", "Runningupthat Hill", "Mount Bicycle", "Damon Hill", "Molehill Mountain", "Mount Everest", "Slieve Rolledup", "Offshore X-13a", "Offshore X-13b", "Barmouth"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(2234, 3765),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
