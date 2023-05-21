using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ICitiesService _citiesService;
        
        public WeatherController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }


        [Route("/")]
        public IActionResult Index()
        {

            List<CityWeather> cities = _citiesService.GetCities();

            return View(cities);
        }


        [Route("Weather/{cityCode}")]
        public IActionResult Details([FromRoute] string cityCode)
        {
            CityWeather cityWeather = _citiesService.GetCityWeatherByCode(cityCode);    

            if(cityWeather == null)
                return NotFound("No city founded with this code");
           
            return View(nameof(Details) ,cityWeather);
        }

    }
}
