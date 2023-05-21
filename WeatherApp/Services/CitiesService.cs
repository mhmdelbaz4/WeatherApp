using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly List<CityWeather> _cities;
        public CitiesService()
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
        public List<CityWeather> GetCities()
        {
            return _cities;
        }

        public CityWeather GetCityWeatherByCode(string CityUniqueCode)
        {
            CityWeather cityWeather = _cities.FirstOrDefault(c => c.CityUniqueCode == CityUniqueCode);

            return cityWeather;
        }
    }
}
