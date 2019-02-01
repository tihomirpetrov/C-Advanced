namespace P09.ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] divideNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();

            Func<int, bool>[] predicates = divideNumbers.Select(div => (Func<int, bool>)(x => x % div == 0)).ToArray();
            
            for (int i = 1; i <= n; i++)
            {
                if (isValid(predicates, i))
                {
                    numbers.Enqueue(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool isValid(Func<int, bool>[] predicates, int num)
        {
            foreach (var predicate in predicates)
            {
                if (!predicate(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}