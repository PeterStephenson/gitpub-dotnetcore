using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using multiplication_api;
using multiplication_api.Controllers;

namespace multiplication_tests
{
    public class TestMultiplicationApi : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var mockMultiplier = new Mock<IMultiplier>();
            mockMultiplier.Setup(m => m.MultiplyNumbers(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int lhs, int rhs) => lhs * rhs);

            builder.ConfigureServices(sp =>
            {
                sp.AddSingleton(mockMultiplier.Object);
            });
        }
    }
}