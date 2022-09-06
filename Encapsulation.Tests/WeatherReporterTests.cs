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
        public void Given_Certain_Locations_And_Tempartures_It_Should_Return_Correct_Weather_Information()
        {
            var WeatherReport = new WeatherReporter("London", 9);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.");

            WeatherReport = new WeatherReporter("London", 30);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 86.");

            WeatherReport = new WeatherReporter("London", 33);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. It's too hot 🥵!. The temperature in Fahrenheit is 91.4.");
        }


        [Test]
        public void Given_Locations_Get_Location_Symbol()
        {
            var WeatherReport = new WeatherReporter("London", 10);
            WeatherReport.GetLocationSymbol().Should().Be("🌦");

            WeatherReport = new WeatherReporter("California", 23);
            WeatherReport.GetLocationSymbol().Should().Be("🌅");

            WeatherReport = new WeatherReporter("Cape Town", 34);
            WeatherReport.GetLocationSymbol().Should().Be("🌤");

            WeatherReport = new WeatherReporter("Leicester", 34);
            WeatherReport.GetLocationSymbol().Should().Be("🔆");
        }

        [Test]
        public void Given_A_Temperature_Get_Temperature_Info()
        {
            var WeatherReport = new WeatherReporter("London", 9);
            WeatherReport.DisplayTemperatureInfo().Should().Be("It's too cold 🥶!");

            WeatherReport = new WeatherReporter("California", 14);
            WeatherReport.DisplayTemperatureInfo().Should().Be("Ahhh...it's just right 😊!");

            WeatherReport = new WeatherReporter("Cape Town", 31);
            WeatherReport.DisplayTemperatureInfo().Should().Be("It's too hot 🥵!");
        }
    }
}

