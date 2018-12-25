namespace P01.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var charFromInput in input)
            {
                stack.Push(charFromInput);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}