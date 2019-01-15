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
            Queue<int> orders = new Queue<int>(quantityOfOrders.Reverse());

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (foodQuantity > orders.Sum())
                {
                    foodQuantity -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (foodQuantity >= orders.Sum())
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {orders.Peek()}");
            }
        }
    }
}