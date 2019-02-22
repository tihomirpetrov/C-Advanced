namespace P04.CupsAndBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int cup = cups.Dequeue();

                while (cup > 0)
                {
                    int bottle = bottles.Pop();
                    cup -= bottle;
                }
                wastedWater += Math.Abs(cup);
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}