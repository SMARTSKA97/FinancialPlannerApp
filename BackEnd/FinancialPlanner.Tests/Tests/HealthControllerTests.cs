using System.Net;
using System.Threading.Tasks;
using Miceosoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FinancialPlanner.Tests{
    public class HealthControllerTests : IClassFixture<WebApplicationFactory<Program>>{
        private readonly WebApplicationFactory<Program> _factory;

        public HealthControllerTests(WebApplicationFactory<Program> factory){
            _factory = factory;
        }

        [Fact]
        public async Task Get_ReturnHealthy(){
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/api/health");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Healthy", content);
        }
    }
}