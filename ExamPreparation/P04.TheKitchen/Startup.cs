namespace P04.TheKitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> knives = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> forks = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sets = new List<int>();           

            while (knives.Count > 0 && forks.Count > 0)
            {
                if (knives[knives.Count - 1] > forks[0])
                {
                    sets.Add(knives[knives.Count - 1] + forks[0]);
                    knives.RemoveAt(knives.Count - 1);
                    forks.RemoveAt(0);
                }
                else if (knives[knives.Count - 1] < forks[0])
                {
                    knives.RemoveAt(knives.Count - 1);
                    continue;
                }
                else if(knives[knives.Count - 1] == forks[0])
                {
                    forks.RemoveAt(0);
                    knives[knives.Count - 1]++;
                }
            }

            Console.WriteLine($"The biggest set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}