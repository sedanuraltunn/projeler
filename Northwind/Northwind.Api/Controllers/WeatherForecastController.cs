using Microsoft.AspNetCore.Mvc;

namespace Northwind.Api.Controllers
{
    [ApiController]
    [Route("[controller]")] //[] i�inde oldu�undan controller�n ad� ne ise route tan�m� o �ekilde olur. K��eli parantez olmadan [Route("hava-durumu")] �eklinden olsayd� route tan�m� ../hava-durumu �eklinde olurdu.
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        [HttpGet] //Bu aksiyona yaln�zca get iste�i yap�l�rsa eri�ilebilir. Bu attribute kullan�lmazsa post, delete, get metotlar�n�n her birinde bu aksiyona ula��labilir
        public IEnumerable<WeatherForecast> Get() //controller i�indeki public metotlar action olarak adland�r�l�r
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