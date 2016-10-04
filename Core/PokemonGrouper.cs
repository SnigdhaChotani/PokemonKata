using System.Collections.Generic;
using System.Linq;
using Core.Interfaces;

namespace Core
{
    public class PokemonGrouper
    {
        public List<List<IPokemon>> PokemonGroups;

        public PokemonGrouper()
        {
            PokemonGroups=new List<List<IPokemon>>();
        }

        public void GroupPokemon(IPokemon pokemon)
        {
            foreach (var pokemonGroup in PokemonGroups)
            {
                var isInGroup = IsInGroup(pokemon, pokemonGroup);
                if (!isInGroup)
                {
                    AddPokemonToGroup(pokemon, pokemonGroup);
                    return;
                }
            }

            var newPokemonGroup = new List<IPokemon> { pokemon };
            PokemonGroups.Add(newPokemonGroup);
        }


        public void AddPokemonToGroup(IPokemon newPokemon, List<IPokemon> pokemonGroup)
        {
            var isInGroup = IsInGroup(newPokemon, pokemonGroup);

            if (!isInGroup)
            {
                pokemonGroup.Add(newPokemon);
            }
        }


        public bool IsInGroup(IPokemon newPokemon, List<IPokemon> pokemonGroup)
        {
            return pokemonGroup.Any(x => x.Name == newPokemon.Name);
        }
    }
}
