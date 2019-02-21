namespace P01.SportCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> cardSportPrice = new Dictionary<string, Dictionary<string, double>>();

            while (command != "end")
            {
                if (!command.Contains("check"))
                {
                    string[] input = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string card = input[0];
                    string sport = input[1];
                    double price = double.Parse(input[2]);

                    if (!cardSportPrice.ContainsKey(card))
                    {
                        cardSportPrice.Add(card, new Dictionary<string, double>());
                    }
                    if (!cardSportPrice[card].ContainsKey(sport))
                    {
                        cardSportPrice[card].Add(sport, price);
                    }
                    cardSportPrice[card][sport] = price;
                }
                else
                {
                    string[] input = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string card = input[1];
                    if (cardSportPrice.ContainsKey(card))
                    {
                        Console.WriteLine($"{card} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{card} is not available!");
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var card in cardSportPrice.OrderByDescending(x =>x.Value.Values.Count))
            {
                Console.WriteLine($"{card.Key}:");
                foreach (var item in card.Value.OrderBy(x =>x.Key))
                {
                    Console.WriteLine($"  -{item.Key} - {item.Value:f2}");
                }
            }
        }
    }
}