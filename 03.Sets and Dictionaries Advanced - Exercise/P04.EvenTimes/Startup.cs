namespace P04.EvenTimes
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> sequenceNumbers = new List<int>();
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < sequenceNumbers.Count; j++)
                {
                    if (number == sequenceNumbers[j])
                    {
                        numbers.Add(number);
                    }
                }
                sequenceNumbers.Add(number);

            }

            Console.WriteLine(string.Join(" ", numbers));           
        }
    }
}