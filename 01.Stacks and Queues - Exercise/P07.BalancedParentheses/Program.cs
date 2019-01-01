namespace P07.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Queue<int> queue = new Queue<int>();
            int halfLength = input.Length / 2;
            Queue<char> openingBrackets = new Queue<char>();
            Queue<char> closingBrackets = new Queue<char>();

            for (int i = 0; i < input.Length; i++)
            {
                openingBrackets.Enqueue(input[i]);
                closingBrackets.Enqueue(input[input.Length - 1 - i]);

                char open = openingBrackets.Dequeue();
                char close = closingBrackets.Dequeue();

                if (open == '(' && close == ')')
                {
                    queue.Enqueue(i);
                }

                else if (open == '{' && close == '}')
                {
                    queue.Enqueue(i);
                }

                else if (open == '[' && close == ']')
                {
                    queue.Enqueue(i);
                }
            }
            if (queue.Count == halfLength)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}