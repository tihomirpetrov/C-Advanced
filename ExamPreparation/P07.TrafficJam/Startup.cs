namespace P07.TrafficJam
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> vehicles = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();

            while (command != "end")
            {

                if (command != "green")
                {
                    string vehicle = command;
                    vehicles.Enqueue(vehicle);
                }
                else if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (vehicles.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{vehicles.Dequeue()} passed!");
                        count++;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}