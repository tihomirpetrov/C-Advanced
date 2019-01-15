namespace P03.MaximumAndMinimumElement
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
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];

                if (command == "1")
                {
                    int numberToPush = int.Parse(tokens[1]);
                    numbers.Push(numberToPush);
                }

                else if (command == "2")
                {
                    if (numbers.Count < 1)
                    {
                        continue;
                    }
                    numbers.Pop();
                }

                else if (command == "3")
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }

                else if (command == "4")
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}