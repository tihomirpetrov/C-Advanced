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
            //string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, string>> continentCountryCities = new Dictionary<string, Dictionary<string, string>>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentCountryCities.ContainsKey(continent))
                {
                    continentCountryCities.Add(continent, new Dictionary<string, string>());
                }
                if (!continentCountryCities[continent].ContainsKey(country))
                {
                    continentCountryCities[continent].Add(country, city);
                }
                continentCountryCities[continent][country] = city;
            }

            foreach (var continent in continentCountryCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var city in continent.Value)
                {
                    Console.Write($"{city.Key} -> ");
                    Console.WriteLine(string.Join(", ", $"{city.Value}"));
                }
            }
        }
    }
}