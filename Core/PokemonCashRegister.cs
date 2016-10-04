using System;
using System.Collections.Generic;

namespace Core
{
    public class PokemonCashRegister
    {
        private static Dictionary<string, int> _pokemondict;
        private static Dictionary<int, double> _discount;

        public PokemonCashRegister()
        {
            _pokemondict = new Dictionary<string, int>
            {
                {"Pikachu", 6},
                {"Squirtle", 5},
                {"Charmander", 5}
            };

            _discount = new Dictionary<int, double> { { 0, 0.0 }, { 1, 0.0 }, { 2, 0.1 }, { 3, 0.2 } };
        }

        public static double CalculateBill(string[] toys)
        {
            double sum = 0;
            int k = 0;

            var areToysToSum = toys.Length > 0;
            if (areToysToSum)
            {
                var isAlreadyInGroup = _pokemondict.ContainsKey(toys[0]);
                if (isAlreadyInGroup)
                {
                    sum = GetSum(toys, toys.Length, sum, _pokemondict, k, _discount);
                    return sum;
                }

                var message = "This pokemon is not available";
                Console.WriteLine(message);
            }
            else
            {
                var message = "Select at least one pokemon";
                Console.WriteLine(message);
            }

            return 0;
        }

        private static double GetSum(string[] toys, int toycount, double sum, Dictionary<string, int> pokemondict, int k, Dictionary<int, double> discount)
        {
            for (int i = 1; i <= toycount; i++)
            {
                sum = sum + pokemondict[toys[i - 1]];
                sum = sum - k*(CalculateDiscount(sum, discount[k]));
            }
            return sum;
        }

        private static double CalculateDiscount(double sum1, double toycount1)
        {

            double discount1 = (toycount1 * sum1);
            return discount1;

        }
    }
}


