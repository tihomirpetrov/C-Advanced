namespace P03.DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Stack<int> numToBinary = new Stack<int>();

            if (number == 0)
            {
                Console.WriteLine(0);
            }

            while (number != 0)
            {
                numToBinary.Push(number % 2);
                number /= 2;
            }

            while (numToBinary.Count > 0)
            {
                Console.Write(numToBinary.Pop());
            }
            Console.WriteLine();
        }
    }
}