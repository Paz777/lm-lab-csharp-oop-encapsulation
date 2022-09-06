using Encapsulation.Models;
using NUnit.Framework;
using FluentAssertions;

namespace Encapsulation.Tests
{
    public class WeatherReporterTests
    {
        public WeatherReporterTests()
        {
        }

        [Test]
        public void Given_London_Location_And_Tempartures_It_Should_Return_Correct_Weather_Information()
        {
            var WeatherReport = new WeatherReporter("London", 9);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.");

            WeatherReport = new WeatherReporter("London", 30);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 86.");

            WeatherReport = new WeatherReporter("London", 33);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. It's too hot 🥵!. The temperature in Fahrenheit is 91.4.");
        }

        [Test]
        public void Given_California_Location_And_Tempartures_It_Should_Return_Correct_Weather_Information()
        {
            var WeatherReport = new WeatherReporter("California", 9);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in California and it is 🌅. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.");

            WeatherReport = new WeatherReporter("California", 30);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in California and it is 🌅. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 86.");

            WeatherReport = new WeatherReporter("California", 33);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in California and it is 🌅. It's too hot 🥵!. The temperature in Fahrenheit is 91.4.");
        }

        [Test]
        public void Given_Cape_Town_Location_And_Tempartures_It_Should_Return_Correct_Weather_Information()
        {
            var WeatherReport = new WeatherReporter("Cape Town", 9);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in Cape Town and it is 🌤. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.");

            WeatherReport = new WeatherReporter("Cape Town", 30);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in Cape Town and it is 🌤. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 86.");

            WeatherReport = new WeatherReporter("Cape Town", 33);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in Cape Town and it is 🌤. It's too hot 🥵!. The temperature in Fahrenheit is 91.4.");
        }

        [Test]
        public void Given_Various_Locations_And_Tempartures_It_Should_Return_Correct_Weather_Information()
        {
            var WeatherReport = new WeatherReporter("Leicester", 9);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in Leicester and it is 🔆. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.");

            WeatherReport = new WeatherReporter("Manchester", 30);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in Manchester and it is 🔆. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 86.");

            WeatherReport = new WeatherReporter("Liverpool", 33);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in Liverpool and it is 🔆. It's too hot 🥵!. The temperature in Fahrenheit is 91.4.");
        }
    }
}

