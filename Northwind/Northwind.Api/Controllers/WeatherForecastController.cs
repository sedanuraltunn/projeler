using Microsoft.AspNetCore.Mvc;

namespace Northwind.Api.Controllers
{
    [ApiController]
    [Route("[controller]")] //[] içinde olduðundan controllerýn adý ne ise route tanýmý o þekilde olur. Köþeli parantez olmadan [Route("hava-durumu")] þeklinden olsaydý route tanýmý ../hava-durumu þeklinde olurdu.
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        [HttpGet] //Bu aksiyona yalnýzca get isteði yapýlýrsa eriþilebilir. Bu attribute kullanýlmazsa post, delete, get metotlarýnýn her birinde bu aksiyona ulaþýlabilir
        public IEnumerable<WeatherForecast> Get() //controller içindeki public metotlar action olarak adlandýrýlýr
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}