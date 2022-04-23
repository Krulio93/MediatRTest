using MediatR;
using MediatRTests.DTO;

namespace MediatRTests.Handler
{
    public class WeatherforecastRequest : IRequest<WeatherForecastResponse>
    {
    }
}
