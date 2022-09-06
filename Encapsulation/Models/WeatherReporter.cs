using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public string _location;
        public double _temperature;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string DisplayWeatherReport()
        {
            return $"I am in {_location} and it is {DisplayLocationSymbol()}. {DisplayTemperatureInfo()}. The temperature in Fahrenheit is {ConvertToFahrenheit(_temperature)}.";
        }

        private double ConvertToFahrenheit(double celsius) => (9.0 / 5.0) * celsius + 32;

        public string DisplayLocationSymbol()
        {
            if (_location == "London")
            {

                return "🌦";

            }
            else if (_location == "California")
            {

                return "🌅";

            }
            else if (_location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        public string DisplayTemperatureInfo()
        {
            if (_temperature > 30)
            {

                return "It's too hot 🥵!";

            }
            else if (_temperature < 10)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

