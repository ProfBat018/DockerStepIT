using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCars")]
        public IActionResult Index()
        {
            using FileStream fs = new("carsData.json", FileMode.OpenOrCreate);
            using StreamReader sr = new(fs);
            string json = sr.ReadToEnd();

            return Ok(json);
        }
    }
}