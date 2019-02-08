namespace P01.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> stackOfChars = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char singleChar = input[i];
                stackOfChars.Push(singleChar);
            }

            Console.WriteLine(string.Join("",stackOfChars));
        }
    }
}