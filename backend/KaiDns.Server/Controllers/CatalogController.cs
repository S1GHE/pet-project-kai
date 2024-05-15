using KaiDns.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace KaiDns.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CatalogController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CatalogController> _logger;
        private readonly Db4660Context _context;

        public CatalogController(ILogger<CatalogController> logger,Db4660Context context)
        {
            _logger = logger;
            _context = context;
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

        [HttpGet(Name = "GetCatalog")]
        public IEnumerable<Catalog> GetCatalogs()
        {
            var catalogs = _context.Catalogs;
            return catalogs.ToList();
        }


    }
}