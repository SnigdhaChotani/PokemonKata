using System.Collections.Generic;
using System.Linq;
using Core;
using Core.Interfaces;
using Core.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Unit.Core.PokemonGrouperShould
{
    [TestFixture]
    public class AddPokemonToGroupShould
    {
        private PokemonGrouper _pokemonGrouper;

        [SetUp]
        public void BeforeEach()
        {
            _pokemonGrouper = new PokemonGrouper();
        }

        [Test]
        public void AddPokemonToGroup_IfNotInGroup()
        {
            var pikachu = new Pikachu();
            var pokemons = new List<IPokemon> { new Charmander() };

            _pokemonGrouper.AddPokemonToGroup(pikachu, pokemons);

            pokemons.Should().Contain(x => x.Name == pikachu.Name);
        }

        [Test]
        public void NotAddPokemonToGroup_IfInGroup()
        {
            var pikachu = new Pikachu();
            var pokemons = new List<IPokemon> { new Pikachu(), new Pikachu() };

            _pokemonGrouper.AddPokemonToGroup(pikachu, pokemons);

            var numberOfPikachu = pokemons.Count(x => x.Name == pikachu.Name);
            numberOfPikachu.ShouldBeEquivalentTo(1);
        }
    }
}
