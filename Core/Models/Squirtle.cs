using Core.Interfaces;

namespace Core.Models
{
    public class Squirtle : IPokemon
    {

        public string Name { get; private set; }
        public int Price { get; private set; }

        public Squirtle()
        {
            Name = "Squirtle";
            Price = 5;
        }
    }
}
