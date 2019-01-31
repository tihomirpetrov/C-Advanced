﻿namespace P01.SortEvenNumbers
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}