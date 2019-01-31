namespace P05.FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> namesAges = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                if (!namesAges.ContainsKey(name))
                {
                    namesAges.Add(name, age);
                }
            }

            string condition = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            foreach (var name in namesAges)
            {
                Console.WriteLine(CreateTester(name));
            }


        }
        public static Func<int, bool> CreateTester(string condition, int ages)
        {
            switch (condition)
            {
                case "younger": return x => x < ages;
                case "older": return x => x >= ages;
                default: return null;
            }
        }
    }
}