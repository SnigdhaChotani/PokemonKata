using Core;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit.Core.PokemonShould
{
    [TestFixture]
    public class CalculateBillShould
    {
        [Test]
        public void ReturnSixDollars_WhenPurchasing_OnePikachu()
        {
            var toysToPurchase = new string[1] { "Pikachu" };
            var bill = PokemonCashRegister.CalculateBill(toysToPurchase);
            bill.ShouldBeEquivalentTo(6);
        }

        [Test]
        public void ReturnSixDollars_WhenPurchasing_TwoPikachu()
        {
            var toysToPurchase = new string[8] { "Pikachu", "Squirtle", "Pikachu", "Squirtle", "Pikachu", "Squirtle", "Pikachu", "Squirtle"};
            var bill = PokemonCashRegister.CalculateBill(toysToPurchase);
            bill.ShouldBeEquivalentTo(38.40);
        }

        [Test]
        public void ReturnBillForZero()
        {
            
        }
        [Test]
        public void ReturnBillForOne()
        {
           
        }

        [Test]
        public void ReturnBillForTwo()
        {
            
        }

        [Test]
        public void ReturnBillForFour()
        {
           
        }
    }
}
