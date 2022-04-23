using MediatR;
using MediatRTests.DTOs;
using MediatRTests.Handler;
using Microsoft.AspNetCore.Mvc;

namespace MediatRTests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;
        private readonly IMediator mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get(CancellationToken cancellationToken)
        {
            var response = await mediator.Send(new WeatherforecastRequest(), cancellationToken);
            return response.WeatherForecasts;
        }
    }
}