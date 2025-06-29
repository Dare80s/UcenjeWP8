using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[ApiController]
    //[Route("[controller]")] // ime klase bez controller. Ova klasa WeatherForecast
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Hladno je", "Vruæe je", "Ugodno "
        };

 

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            
            foreach(var item in Request.Headers)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine("********************************");
            
            Console.WriteLine(
                Request
                .Headers["sec-ch-ua"]
                .ToString()
                .Split(";")[0]
                .Replace("\"","")
                );

            WeatherForecast[] niz = new WeatherForecast[5];
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = new WeatherForecast() { 
                Date = DateOnly.FromDateTime(new DateTime(2000,2,4)),
                TemperatureC = 12,
                Summary= Summaries[Random.Shared.Next(Summaries.Length)]
                };
            }
            return niz;
            /*
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            */
        }
    }
}
