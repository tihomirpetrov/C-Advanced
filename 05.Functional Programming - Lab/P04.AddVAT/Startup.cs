namespace P04.AddVAT
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Func<string, double> parser = x => double.Parse(x) * 1.2;

            double[] prices = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}