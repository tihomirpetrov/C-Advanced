namespace P07.PredicateForNames
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int wordLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            PrintNames(names, w =>w.Length, wordLength);

        }

        private static void PrintNames(string[] names, Func<object, object> p, int wordLength)
        {
            throw new NotImplementedException();
        }
    }
}


