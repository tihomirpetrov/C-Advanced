namespace P04.MatchingBrackets
{
    using System;
    using System.Collections.Generic;
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> expressions = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    expressions.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = expressions.Pop();
                    string reminder = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(reminder);
                }
            }
        }
    }
}