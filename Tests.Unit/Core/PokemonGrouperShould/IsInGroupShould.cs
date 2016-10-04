using System.Collections.Generic;
using Core;
using Core.Interfaces;
using Core.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit.Core.PokemonGrouperShould
{
    [TestFixture]
    public class IsInGroupShould
    {
        private PokemonGrouper _pokemonGrouper;

        [SetUp]
        public void BeforeEach()
        {
            _pokemonGrouper = new PokemonGrouper();
        }

        [Test]
        public void ReturnTrue_IfPokemonIsAlreadyInGroup()
        {
            var pikachu = new Pikachu();
            var pokemons = new List<IPokemon> {new Pikachu()};

            var isInGroup = _pokemonGrouper.IsInGroup(pikachu, pokemons);

            isInGroup.Should().BeTrue();
        }

        [Test]
        public void ReturnFalse_IfPokemonIsNotInGroup()
        {
            var pikachu = new Pikachu();
            var pokemons = new List<IPokemon> { new Squirtle(), new Charmander() };

            var isInGroup = _pokemonGrouper.IsInGroup(pikachu, pokemons);

            isInGroup.Should().BeFalse();
        }
    }
}
