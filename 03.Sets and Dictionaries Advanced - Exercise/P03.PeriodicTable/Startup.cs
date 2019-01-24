namespace P03.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> chemicalElements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var item in input)
                {
                    chemicalElements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalElements.OrderBy(x => x)));         
        }
    }
}