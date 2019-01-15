namespace P03.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();
            Stack<string> elements = new Stack<string>(tokens.Reverse());

            while (elements.Count > 1)
            {
                int firstNumber = int.Parse(elements.Pop());
                string operand = elements.Pop();
                int secondNumber = int.Parse(elements.Pop());

                if (operand == "+")
                {
                    elements.Push((firstNumber + secondNumber).ToString());
                }
                else if (operand == "-")
                {
                    elements.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(elements.Pop());
        }
    }
}