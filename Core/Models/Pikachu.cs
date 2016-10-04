using Core.Interfaces;

namespace Core.Models
{
    public class Pikachu : IPokemon
    {

        public string Name { get; private set; }
        public int Price { get; private set; }

        public Pikachu()
        {
            Name = "Pikachu";
            Price = 6;
        }
    }
}
