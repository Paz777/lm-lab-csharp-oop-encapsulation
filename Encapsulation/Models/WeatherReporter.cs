using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private Dictionary<string, string> _cityLocationSymbol = new Dictionary<string, string>()
        {
            {"London", "🌦" },
            {"California", "🌅" },
            {"Cape Town", "🌤" }
        };

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string DisplayWeatherReport()
            => $"I am in {_location} and it is {GetLocationSymbol()}. {DisplayTemperatureInfo()}. The temperature in Fahrenheit is {ConvertToFahrenheit(_temperature)}.";

        private double ConvertToFahrenheit(double celsius)
            => (9.0 / 5.0) * celsius + 32;

        private string GetLocationSymbol()
        {
            try
            {
                return _cityLocationSymbol[_location];
            }
            catch (Exception ex)
            {
                return "🔆";
            }
        }

        private string DisplayTemperatureInfo()
            => _temperature > 30 ? "It's too hot 🥵!" : (_temperature < 10 ? "It's too cold 🥶!" : "Ahhh...it's just right 😊!");
    }
}

