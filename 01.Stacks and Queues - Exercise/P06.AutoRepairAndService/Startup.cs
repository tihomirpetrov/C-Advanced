namespace P06.AutoRepairAndService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] sequenceOfCars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> servedCars = new Queue<string>(sequenceOfCars);
            Stack<string> carsServedAlready = new Stack<string>();
            string[] command = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "End")
            {

                if (command[0] == "Service")
                {
                    if (servedCars.Any())
                    {
                        string servedCar = servedCars.Dequeue();
                        carsServedAlready.Push(servedCar);
                        Console.WriteLine($"Vehicle {servedCar} got served.");
                    }
                }
                else if (command[0] == "CarInfo")
                {
                    string modelName = command[1];
                    if (servedCars.Contains(modelName))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command[0] == "History")
                {
                    Console.WriteLine(string.Join(", ", carsServedAlready));
                }
                command = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (servedCars.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", servedCars)}");                
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", carsServedAlready)}");
        }
    }
}