namespace P03.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Stack<string> elements = new Stack<string>(Console.ReadLine().Split().ToArray());
            Stack<int> numbers = new Stack<int>();
            elements.Reverse();

            foreach (var element in elements)
            {
                if (element == "+")
                {
                    numbers.Push(int.Parse(element));
                }
                else if (element == "-")
                {
                    //numbers.Pop(int.Parse(element));
                }
                else
                {
                    numbers.Push(int.Parse(element));
                    elements.Pop();
                }
            }
        }
    }
}