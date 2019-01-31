namespace P02.SumNumbers_2
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Func<string, int> parser = x => int.Parse(x);
            int[] numbers = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}