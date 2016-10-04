using Core;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit.Core.StringParserShould
{
    [TestFixture]
    public class RemoveNumbersShould
    {
        [Test]
        public void ReturnExactString_WhenHasNoNumbers()
        {
            var result = StringParser.RemoveNumbers("foo");
            result.Should().BeEquivalentTo("foo");
        }

        [Test]
        public void RemoveLeadingNumbers()
        {
            var result = StringParser.RemoveNumbers("222foo");
            result.Should().BeEquivalentTo("foo");
        }

        [Test]
        public void RemoveTrailingNumbers()
        {
            var result = StringParser.RemoveNumbers("foo22");
            result.Should().BeEquivalentTo("foo");
        }
    }
}
