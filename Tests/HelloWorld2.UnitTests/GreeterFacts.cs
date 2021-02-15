using System;
using Xunit;

namespace HelloWorld2.UnitTests
{
    public class GreeterFacts
    {
        [Fact]
        public void Should_return_non_empty_message()
        {
            var greeter = new Greeter();

            var result = greeter.SayHello();

            Assert.NotNull(result);
        }
    }
}
