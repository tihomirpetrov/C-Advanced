namespace P03.CustomMinFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[], int> minFunc = GetMin;

            var minNumber = minFunc(numbers);

            Console.WriteLine(minNumber);
        }

        public static int GetMin(int[] numbers)
        {
            var min = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}