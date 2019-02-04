namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] fourTires = new Tire[4]
                {
                      new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                      new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                      new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                      new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),
                };
                tires.Add(fourTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int engineHorsePower = int.Parse(tokens[0]);
                double engineCubicCapacity = double.Parse(tokens[1]);
                Engine engine = new Engine(engineHorsePower, engineCubicCapacity);
                engines.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);


                input = Console.ReadLine();
            }
        }
    }
}