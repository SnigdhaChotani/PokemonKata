using Core;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit.Core.CashRegisterShould
{
    [TestFixture]
    public class GetGroupDiscountShould
    {
        private CashRegister _cashRegister;

        [SetUp]
        public void BeforeEach()
        {
            _cashRegister = new CashRegister();
        }

        [Test]
        public void Give10whenGiven_GroupSize2()
        {
            var groupSize = 2;
            var result = _cashRegister.GetGroupDiscount(groupSize);
            result.ShouldBeEquivalentTo(.10);
        }
        [Test]
        public void Give20whenGiven_GroupSize3()
        {
            var groupSize = 3;
            var result = _cashRegister.GetGroupDiscount(groupSize);
            result.ShouldBeEquivalentTo(.20);
        }

    }
}
