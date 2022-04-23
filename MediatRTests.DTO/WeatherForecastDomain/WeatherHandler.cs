using MediatR;
using MediatRTests.DTO;
using MediatRTests.DTOs;
using MediatRTests.Handler;

namespace MediatRTests.WeatherForecastDomain
{
    public class WeatherHandler : IRequestHandler<WeatherforecastRequest,  WeatherForecastResponse>
    {
        private readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecastResponse> Handle(WeatherforecastRequest request, CancellationToken cancellationToken)
        {
            var elements = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();


            return Task.FromResult(new WeatherForecastResponse(elements)); 
        }

        
    }
}
