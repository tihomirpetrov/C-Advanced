
namespace P05.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> symbolsCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (!symbolsCount.ContainsKey(symbol))
                {
                    symbolsCount[symbol] = 0;
                }
                symbolsCount[symbol]++;
            }

            foreach (var item in symbolsCount.OrderBy(x =>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}