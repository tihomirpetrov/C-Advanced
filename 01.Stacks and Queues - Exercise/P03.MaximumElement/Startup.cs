namespace P03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < sequence.Length; j++)
                {
                    numbers.Push(sequence[j]);
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine(numbers.Max());
                }
            }
        }
    }
}