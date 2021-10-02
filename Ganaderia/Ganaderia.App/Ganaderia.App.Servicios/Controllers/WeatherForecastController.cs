using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ganadero> Get()
        {
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();

            Ganadero ganadero = new Ganadero 
            {
                Nombre = "Andres",
                Apellido = "Herrera",
                NumeroTelefono = "3148569865",
                Correo = "sergio.mintic@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            Ganadero ganadero2 = new Ganadero 
            {
                Nombre = "Santiago",
                Apellido = "Herrera",
                NumeroTelefono = "3148569865",
                Correo = "sergio.mintic@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            List<Ganadero> Ganaderos = new List<Ganadero>();
            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero2);
            return Ganaderos; 
        }
    }
}
