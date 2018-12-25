namespace P06.TrafficJam
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        public static void Main()
        {
            int carsInGreenLight = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> carsQueue = new Queue<string>();
            int carsCount = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    int carsThatCanPass = Math.Min(carsQueue.Count, carsInGreenLight);
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carsCount++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsCount} cars passed the crossroads.");
        }
    }
}