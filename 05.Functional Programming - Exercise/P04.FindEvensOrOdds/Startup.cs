namespace P04.FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int lowerBound = input[0];
            int upperBound = input[1];
            string command = Console.ReadLine();

            Predicate<int> predicate;

            switch (command)
            {
                case "odd":
                    predicate = n => n % 2 != 0;
                    break;

                case "even":
                    predicate = n => n % 2 == 0;
                    break;

                default:
                    predicate = null;
                    break;
            }

            var result = EvensOrOdds(lowerBound, upperBound, predicate);
            Console.WriteLine(string.Join(" ", result));
        }

        private static Queue<int> EvensOrOdds(int lowerBound, int upperBound, Predicate<int> predicate)
        {
            Queue<int> numbers = new Queue<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (predicate(i))
                {
                    numbers.Enqueue(i);
                }
            }

            return numbers;
        }
    }
}