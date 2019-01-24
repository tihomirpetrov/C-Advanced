namespace P04.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentCountryCities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentCountryCities.ContainsKey(continent))
                {
                    continentCountryCities.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continentCountryCities[continent].ContainsKey(country))
                {
                    continentCountryCities[continent].Add(country, new List<string>());
                }
                continentCountryCities[continent][country].Add(city);
            }

            foreach (var continent in continentCountryCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var city in continent.Value)
                {
                    Console.Write($"  {city.Key} -> ");
                    Console.WriteLine($"{ string.Join(", ", city.Value)}");                  
                }
            }
        }
    }
}