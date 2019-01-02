namespace P08.StackFibonacci
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Stack<long> fibonacci = new Stack<long>();
            int n = int.Parse(Console.ReadLine());

            fibonacci.Push(0);
            fibonacci.Push(1);

            for (int i = 0; i < n - 1; i++)
            {
                long firstNumber = fibonacci.Pop();
                long secondNumber = fibonacci.Peek();

                fibonacci.Push(firstNumber);
                fibonacci.Push(firstNumber + secondNumber);
            }

            Console.WriteLine(fibonacci.Peek());
        }
    }
}