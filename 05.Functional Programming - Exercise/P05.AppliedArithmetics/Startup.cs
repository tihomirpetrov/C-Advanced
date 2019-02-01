namespace P05.AppliedArithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = ForEach(numbers, n => n + 1);
                        break;

                    case "subtract":
                        numbers = ForEach(numbers, n => n - 1);
                        break;

                    case "multiply":
                        numbers = ForEach(numbers, n => n * 2);
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static IEnumerable<int> ForEach(IEnumerable<int> numbers, Func<int, int> func)
        {
            return numbers.Select(n => func(n));
        }
    }
}