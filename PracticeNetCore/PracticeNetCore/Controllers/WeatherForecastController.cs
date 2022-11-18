using Microsoft.AspNetCore.Mvc;

namespace PracticeNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freesadsadsadsadsadsadsdddddđadsadsadzing", "Bracindfsdfg", "Chsadsadilly", "Cosadsadol", "Hodsádsadsadfsdft", "Swelterisdfsadsadsadsfdsfng", "Scorchsádsadsaddfsdfdsing"
    };
    private static readonly string[] Summaries2 = new[]
        {
        "Freesadsadsadsadsadsadsadsadsadzing", "Bracindfsdfg", "Chsadsadilly", "Cosadsadol", "Hodsádsadsadfsdft", "Swelterisdfsadsadsadsfdsfng", "Scorchsádsadsaddfsdfdsing"
    };
    private static readonly string[] Summaries3 = new[]
        {
        "Freesadsadsadsadsadsadsadsadsadzing", "Bracindfsdfg", "Chsadsadilly", "Cosadsadol", "Hodsádsadsadfsdft", "Swelterisdfsadsadsadsfdsfng", "Scorchsádsadsaddfsdfdsing"
    };
    private static readonly string[] Summaries4 = new[]
        {
        "Freesadsadsadsadsadsadsadsadsadzing", "Bracindfsdfg", "Chsadsadilly", "Cosadsadol", "Hodsádsadsadfsdft", "Swelterisdfsadsadsadsfdsfng", "Scorchsádsadsaddfsdfdsing"
    };
    private static readonly string[] Summaries5 = new[]
        {
        "Freesadsadsadsadsadsadsadsadsadzing", "Bracindfsdfg", "Chsadsadilly", "Cosadsadol", "Hodsádsadsadfsdft", "Swelterisdfsadsadsadsfdsfng", "Scorchsádsadsaddfsdfdsing"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecasưeeeeeeeeeeeeeeeeeeet")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summaryyy = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet(Name = "GetDawwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwta")]
        public IEnumerable<WeatherForecast> GetData()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summaryyy = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
