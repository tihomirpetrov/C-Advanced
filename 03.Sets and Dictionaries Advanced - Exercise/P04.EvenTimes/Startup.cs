namespace P04.EvenTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            foreach (var number in numbers.Where(x => x % 2 != 0))
            {
                Console.WriteLine(Math.Abs(number));
            }
        }
    }
}