namespace P01.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<double, List<int>> numbers = new Dictionary<double, List<int>>();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double number = double.Parse(input[i]);
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, new List<int>());
                    counter++;
                }
                numbers[number].Add(counter);
            }


            foreach (var item in numbers)
            {
                Console.WriteLine(string.Join(" ", $"{item.Key} - {item.Value.Count()} times"));
            }
        }
    }
}