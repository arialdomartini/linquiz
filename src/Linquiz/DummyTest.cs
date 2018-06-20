using FluentAssertions;
using Xunit;

namespace Linquiz
{
    public class DummyTest
    {
        [Fact]
        public void should_pass()
        {
            "friends".Should().Be("friends");
        }
    }
}