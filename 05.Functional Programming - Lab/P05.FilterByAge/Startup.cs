namespace P05.FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            var people = GetPeople();

            string condition = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, ages);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            InvokePrinter(people, tester, printer);
        }

        private static void InvokePrinter(Dictionary<string, int> namesAges, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in namesAges)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Dictionary<string, int> GetPeople()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Dictionary<string, int> namesAges = new Dictionary<string, int>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] nameAge = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                if (!namesAges.ContainsKey(name))
                {
                    namesAges.Add(name, age);
                }
            }
            return namesAges;
        }

        public static Func<int, bool> CreateTester(string condition, int ages)
        {
            switch (condition)
            {
                case "younger":
                    return x => x < ages;
                case "older":
                    return x => x >= ages;
                default:
                    return null;
            }
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return kvp => Console.WriteLine($"{kvp.Key}");
                case "age":
                    return kvp => Console.WriteLine($"{kvp.Value}");
                case "name age":
                    return kvp => Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                default: return null;
            }
        }
    }
}