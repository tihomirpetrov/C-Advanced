namespace P03.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> elements = new Stack<string>(input.Reverse());

            while (elements.Count > 1)
            {
                int firstNumber = int.Parse(elements.Pop());
                string operand = elements.Pop();
                int secondNumber = int.Parse(elements.Pop());

                switch (operand)
                {
                    case "+":
                        elements.Push((firstNumber + secondNumber).ToString());
                        break;
                    case "-":
                        elements.Push((firstNumber - secondNumber).ToString());
                        break;
                }
            }
            Console.WriteLine(elements.Pop());
        }
    }
}