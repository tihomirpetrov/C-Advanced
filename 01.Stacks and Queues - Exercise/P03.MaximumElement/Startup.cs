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
                string[] tokens = Console.ReadLine().Split().ToArray();
                string command = tokens[0];

                if (command == "1")
                {
                    int numberToPush = int.Parse(tokens[1]);
                    numbers.Push(numberToPush);
                }

                else if (command == "2")
                {
                    numbers.Pop();
                }

                else
                {
                    Console.WriteLine(numbers.Max());
                }
            }
        }
    }
}