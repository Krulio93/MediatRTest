
using MediatRTests.DTOs;

namespace MediatRTests.DTO
{
    public class WeatherForecastResponse
    {
        public WeatherForecastResponse(IEnumerable<WeatherForecast> weatherForecasts)
        {
            WeatherForecasts = weatherForecasts;
        }
        public IEnumerable<WeatherForecast> WeatherForecasts { get; }
    }
}
