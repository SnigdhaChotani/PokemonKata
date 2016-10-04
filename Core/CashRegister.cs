using System.Collections.Generic;
using Core.Interfaces;

namespace Core
{
    public class CashRegister
    {
        private readonly PokemonGrouper _pokemonGrouper;

        public CashRegister()
        {
            _pokemonGrouper = new PokemonGrouper();
        }

        public double GetOrderTotal()
        {
            var orderTotal = 0.0;
            foreach (var pokemonGroup in _pokemonGrouper.PokemonGroups)
            {
                var groupTotal = GetGroupTotal(pokemonGroup);
                orderTotal = groupTotal + orderTotal;
            }
           
            return orderTotal;
        }

        public double GetGroupTotal(List<IPokemon> pokemonGroup)
        {
            var sum = 0.0;
            foreach (var pokemon in pokemonGroup)
            {
                sum += pokemon.Price;
            }
            var groupDiscount = GetGroupDiscount(pokemonGroup.Count);
            return sum - sum*groupDiscount;
        }

        public double GetGroupDiscount(int groupSize)
        {
            return (groupSize - 1)*0.1;
        }

        public void BuyPokemon(IPokemon pokemonToBuy)
        {
            _pokemonGrouper.GroupPokemon(pokemonToBuy);
        }

        public void BuyManyPokemon(IPokemon pokemonToBuy, int numToBuy)
        {
            for (int i = 0; i < numToBuy; i++)
            {
                BuyPokemon(pokemonToBuy);
            }
        }
    }
}
