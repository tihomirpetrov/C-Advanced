namespace P05.Supermarket
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Queue<string> customers = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    string customer = input;
                    customers.Enqueue(customer);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}