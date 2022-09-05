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
            var WeatherReport = new WeatherReporter("London", 30);
            WeatherReport.DisplayWeatherReport().Should().Be("I am in London and it is 🌦. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 86.");
        }
    }
}

