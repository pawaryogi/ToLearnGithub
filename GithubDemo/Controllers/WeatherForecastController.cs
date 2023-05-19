using Microsoft.AspNetCore.Mvc;

namespace GithubDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching","Melting"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //Added Comment on 20/04/2023 by Yogesh
        [HttpGet("GetLoggedInUsername")]
        public string GetLoggedINUserName()
        {
            return "Yogesh Dattaram Pawar";
        }


        // Feature Added on 19/04/23
        [HttpGet("GetMailId")]
        public string GetMailId()
        {
            return "pawar.yogesh@gmail.com";
        }

        
        //Added Comment on 20/04/2023 by Yogesh
        [HttpGet("GetCity")]
        public string GetCity()
        {
            return "Thane";

        }

        //Feature-1 Added
        [HttpGet("GetContactNo")]
        public string GetContactNo()
        {
            return "9988776655";

        }
    }
}
