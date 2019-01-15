namespace P04.FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] quantityOfOrders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(quantityOfOrders);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < quantityOfOrders.Length; i++)
            {
                if (foodQuantity >= orders.Peek())
                {
                    foodQuantity -= orders.Dequeue();
                }
            }
                       
            if (foodQuantity >= orders.Sum())
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}