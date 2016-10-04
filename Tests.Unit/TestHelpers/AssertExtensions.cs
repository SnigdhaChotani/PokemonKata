using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit.TestHelpers
{
    public static class AssertExtensions
    {
        public static void IsEqualToPenny(this double value, double valueToCompare) {
            Assert.AreEqual(value, valueToCompare, .009);
        }
    }
}
