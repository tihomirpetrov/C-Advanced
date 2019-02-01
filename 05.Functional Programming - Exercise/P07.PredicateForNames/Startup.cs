namespace P07.PredicateForNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int wordLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            PrintNames(names, w => w.Length <= wordLength);
        }

        private static void PrintNames(IEnumerable<string> names, Func<string, bool> Filter)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names.Where(Filter)));
        }
    }
}