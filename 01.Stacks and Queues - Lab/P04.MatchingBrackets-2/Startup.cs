namespace P04.MatchingBrackets_2
{
    using System;
    using System.Collections.Generic;

    class Startup
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
                    int openBracket = expressions.Pop();
                    string subExpression = input.Substring(openBracket, i - openBracket + 1);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}