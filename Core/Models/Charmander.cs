using Core.Interfaces;

namespace Core.Models
{
    public class Charmander : IPokemon
    {
        public string Name { get; }
        public int Price { get; }

        public Charmander()
        {
            Name = "Charmander";
            Price = 5;
        }
    }
}
