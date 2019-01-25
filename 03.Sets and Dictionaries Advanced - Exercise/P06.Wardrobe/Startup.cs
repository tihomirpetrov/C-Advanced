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
            Dictionary<string, List<string>> colorClothes = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!colorClothes.ContainsKey(color))
                {
                    colorClothes.Add(color, new List<string>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    colorClothes[color].Add(clothes[j]);
                }
            }
            string[] colorItem = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string clothingColor = colorItem[0];
            string clothingItem = colorItem[1];

            if (colorClothes.ContainsKey(clothingColor))
            {
                Console.WriteLine($"{clothingColor} clothes:");
            }
            foreach (var clothe in colorClothes)
            {
                foreach (var item in clothe.Value)
                {
                    Console.WriteLine($"* {item} - {clothe.Value.Count}");
                }
            }
        }
    }
}