namespace P07.BalancedParentheses_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Stack<char> stackOfParentheses = new Stack<char>();
            string parentheses = Console.ReadLine();
            char[] openParantheses = new char[] { '(', '[', '{' };
            bool isValid = true;
            for (int i = 0; i < parentheses.Length; i++)
            {
                char currentBracket = parentheses[i];

                if (openParantheses.Contains(currentBracket))
                {
                    stackOfParentheses.Push(currentBracket);
                    continue;
                }
                if (stackOfParentheses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParentheses.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParentheses.Pop();
                }
            }

            if (isValid && stackOfParentheses.Count == 0)
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
