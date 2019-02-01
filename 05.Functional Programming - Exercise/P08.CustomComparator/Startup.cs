namespace P08.CustomComparator
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int, int> comparator = (even, odd) =>
            (even % 2 == 0 && odd % 2 != 0) ? -1 :
            (even % 2 != 0 && odd % 2 == 0) ? 1 :
            even.CompareTo(odd);

            Array.Sort<int>(numbers, new Comparison<int>(comparator));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}