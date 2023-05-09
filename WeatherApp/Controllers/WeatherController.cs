using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {

        readonly List<CityWeather> _cities;


        public WeatherController()
        {
            _cities = new List<CityWeather>()
            {
                new CityWeather(){
                CityUniqueCode = "LDN",
                CityName = "London",
                DateAndTime =new DateTime(year:2030 ,month:01 ,day:01 ,hour:08 ,minute:00,second:00) ,
                TemperatureFahrenheit = 33
                },

                new CityWeather(){
                CityUniqueCode = "NYC",
                CityName = "London",
                DateAndTime =new DateTime(year:2030 ,month:01 ,day:01 ,hour:03 ,minute:00,second:00),
                TemperatureFahrenheit = 60
                },

                new CityWeather(){
                CityUniqueCode = "PAR",
                CityName = "Paris",
                DateAndTime =new DateTime(year:2030 ,month:01 ,day:01 ,hour:09 ,minute:00,second:00),
                TemperatureFahrenheit = 82
                },

            };
        }


        [Route("/")]
        public IActionResult Index()
        {                        
            return View(_cities);
        }


        [Route("Weather/{cityCode}")]
        public IActionResult Details([FromRoute] string cityCode)
        {
            CityWeather cityWeather = _cities.FirstOrDefault(city => city.CityUniqueCode == cityCode);

            if(cityWeather == null)
                return NotFound("No city founded with this code");
           
            return View(nameof(Details) ,cityWeather);
        }

    }
}
