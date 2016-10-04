using Core;
using Core.Models;
using FluentAssertions;
using NUnit.Framework;
using Tests.Unit.TestHelpers;

namespace Tests.Unit.Core.CashRegisterShould
{
    [TestFixture]
    public class GetOrderTotalShould
    {
        private CashRegister _cashRegister;

        [SetUp]
        public void BeforeEach()
        {
            _cashRegister = new CashRegister();
        }

        [Test]
        public void Be6WhenGiven_OnePikachu()
        {
            var pikachu = new Pikachu();
            _cashRegister.BuyPokemon(pikachu);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(6.0);
        }

        [Test]
        public void Be12WhenGiven_2Pikachu()
        {
            var pikachu = new Pikachu();
            _cashRegister.BuyManyPokemon(pikachu, 2);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(12.0);
        }
        [Test]
        public void Be990WhenGiven_1Pikachu1Squirtle()
        {
            var pikachu = new Pikachu();
            var squirtle = new Squirtle();
            _cashRegister.BuyPokemon(pikachu);
            _cashRegister.BuyPokemon(squirtle);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(9.90);
        }
        [Test]
        public void Be1980WhenGiven_2Pikachu2Squirtle()
        {
            var pikachu = new Pikachu();
            var squirtle = new Squirtle();
            _cashRegister.BuyManyPokemon(pikachu,2);
            _cashRegister.BuyManyPokemon(squirtle,2);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(19.80);
        }
        [Test]
        public void Be2970WhenGiven_3Pikachu3Squirtle()
        {
            var pikachu = new Pikachu();
            var squirtle = new Squirtle();
            _cashRegister.BuyManyPokemon(pikachu, 3);
            _cashRegister.BuyManyPokemon(squirtle, 3);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(29.70);
        }
        [Test]
        public void Be1590WhenGiven_2Pikachu1Squirtle()
        {
            var pikachu = new Pikachu();
            var squirtle = new Squirtle();
            _cashRegister.BuyManyPokemon(pikachu, 2);
            _cashRegister.BuyPokemon(squirtle);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(15.90);
        }
        [Test]
        public void Be1280WhenGiven_1Pikachu1Squirtle1Charmander()
        {
            var pikachu = new Pikachu();
            var squirtle = new Squirtle();
            var charmander = new Charmander();
            _cashRegister.BuyPokemon(pikachu);
            _cashRegister.BuyPokemon(squirtle);
            _cashRegister.BuyPokemon(charmander);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(12.80);
        }

        [Test]
        public void Be1880WhenGiven_2Pikachu1Squirtle1Charmander()
        {
            var pikachu = new Pikachu();
            var squirtle = new Squirtle();
            var charmander = new Charmander();
            _cashRegister.BuyManyPokemon(pikachu,2);
            _cashRegister.BuyPokemon(squirtle);
            _cashRegister.BuyPokemon(charmander);

            var result = _cashRegister.GetOrderTotal();

            result.IsEqualToPenny(18.80);
        }
    }
}
