namespace P01.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> myStack = new Stack<char>();

            foreach (var item in input)
            {
                myStack.Push(item);
            }

            foreach (var item in myStack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}