namespace P03.ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, double>> shopProducts = new Dictionary<string, Dictionary <string, double>>();
            Dictionary<string, List<double>> shopPrices = new Dictionary<string, List<double>>();

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shopProducts.ContainsKey(shop))
                {
                    shopProducts.Add(shop, new Dictionary<string, double>());
                }
                shopProducts[shop].Add(product, price);

                //if (!shopPrices.ContainsKey(shop))
                //{
                //    shopPrices.Add(shop, new List<double>());
                //}
                //shopPrices[shop].Add(price);

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var shop in shopProducts.OrderBy(x =>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine(string.Join(" ", $"Product: {product}, "));
                    if (shopPrices.ContainsKey(shop.Key))
                    {
                        Console.WriteLine(string.Join(" ", $"Price: {shopProducts.Where(x => shop.Key == x.Key)}"));
                    }
                }                
            }
        }
    }
}