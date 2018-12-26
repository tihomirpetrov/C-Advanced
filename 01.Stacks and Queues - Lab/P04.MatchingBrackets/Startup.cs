namespace P04.MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string reminder = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(reminder);
                }
            }
        }
    }
}