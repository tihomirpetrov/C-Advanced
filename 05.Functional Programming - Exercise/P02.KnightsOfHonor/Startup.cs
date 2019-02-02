namespace P02.KnightsOfHonor
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(x => Console.WriteLine($"Sir {x}"));

        }
    }
}