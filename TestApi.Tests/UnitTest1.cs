using System.Net;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TestApi.Tests
{
    public class WeatherForecastControllerTests : IClassFixture<WebApplicationFactory<TestApi.Program>>
    {
        private readonly WebApplicationFactory<TestApi.Program> _factory;

        public WeatherForecastControllerTests(WebApplicationFactory<TestApi.Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_ReturnsSuccessAndJsonContentType()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/WeatherForecast");
            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }
    }
}
