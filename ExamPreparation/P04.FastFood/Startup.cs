namespace P04.FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] quantityOfOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>();
            int count = 0;

            for (int i = 0; i < quantityOfOrders.Length; i++)
            {
                if (quantityOfFood >= orders.Sum())
                {
                    orders.Enqueue(quantityOfOrders[i]);
                    quantityOfFood -= quantityOfOrders[i];
                    count++;
                }
                else
                {
                    Console.Write("Orders left: ");

                    for (int j = quantityOfOrders.Length - 1; j >= count; j--)
                    {
                        Console.WriteLine(string.Join(" ", quantityOfOrders[j]));
                    }
                    return;
                }
            }

            Console.WriteLine(orders.Max());

            if (quantityOfFood >= orders.Sum())
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}