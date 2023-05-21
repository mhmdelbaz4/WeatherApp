using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface ICitiesService
    {

        List<CityWeather> GetCities();

        CityWeather GetCityWeatherByCode(string CityUniqueCode);


    }
}
