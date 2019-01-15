namespace P05.Supermarket
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            
            while (input != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }                    
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}