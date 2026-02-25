using GuitarAppBackend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace GuitarAppBackend.Tests
{
    public class WeatherControllerTests
    {
        [Fact]
        public void GetWeather_ReturnsArray()
        {
            var controller = new WeatherController();
            var result = controller.GetWeather() as OkObjectResult;

            Assert.NotNull(result);
            var array = result.Value as string[];
            Assert.Contains("Sunny", array);
            Assert.Contains("Cloudy", array);
            Assert.Contains("Rainy", array);
        }
    }
}