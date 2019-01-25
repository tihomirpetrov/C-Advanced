namespace P06.Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorClothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!colorClothes.ContainsKey(color))
                {
                    colorClothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!colorClothes[color].ContainsKey(clothes[j]))
                    {
                        colorClothes[color][clothes[j]] = 1;
                    }
                    else if (colorClothes[color].ContainsKey(clothes[j]))
                    {
                        colorClothes[color][clothes[j]]++;
                    }
                }
            }
            string[] colorItem = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string clothingColor = colorItem[0];
            string clothingItem = colorItem[1];

            foreach (var clothe in colorClothes)
            {
                Console.WriteLine($"{clothe.Key} clothes:");

                foreach (var item in clothe.Value)
                {
                    if (clothe.Key == clothingColor && item.Key == clothingItem)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}