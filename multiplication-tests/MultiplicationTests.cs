using System;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace multiplication_tests
{
    public class MultiplicationTests
    {
        [Fact]
        public async Task When_multiplying_two_numbers_Then_the_correct_response_is_returned()
        {
            using var multiplicationApi = new TestMultiplicationApi();

            var httpClient = multiplicationApi.CreateClient();

            var result = await httpClient.GetAsync("/multiply?rhs=3&lhs=4");
            
            result.StatusCode.Should().Be(HttpStatusCode.OK);
            var body = await result.Content.ReadAsStringAsync();
            body.Should().Be("12");
        }
    }
}
