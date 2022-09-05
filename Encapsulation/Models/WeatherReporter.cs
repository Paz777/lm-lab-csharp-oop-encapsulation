using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        public string Location;
        public double Temperature;

        public WeatherReporter(string location, double temperature)
        {
            Location = location;
            Temperature = temperature;
        }

        public string DisplayWeatherReport()
        {
            double newTemp = (9.0 / 5.0) * Temperature + 32;
            return $"I am in {Location} and it is {Check1()}. {Check2()}. The temperature in Fahrenheit is {newTemp}.";
        }

        public string Check1()
        {
            if (Location == "London")
            {

                return "🌦";

            }
            else if (Location == "California")
            {

                return "🌅";

            }
            else if (Location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        public string Check2()
        {
            if (Temperature > 30)
            {

                return "It's too hot 🥵!";

            }
            else if (Temperature < 10)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

