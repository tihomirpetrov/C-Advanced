namespace P04.EvenTimes
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> sequenceNumbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!sequenceNumbers.ContainsKey(number))
                {
                    sequenceNumbers[number] = 0;
                }
                sequenceNumbers[number]++;
            }

            foreach (var item in sequenceNumbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}