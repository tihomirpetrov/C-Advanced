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

            string input2 = Console.ReadLine();

            while (input2 != "Engines done")
            {
                string[] tokens = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int engineHorsePower = int.Parse(tokens[0]);
                double engineCubicCapacity = double.Parse(tokens[1]);

                input2 = Console.ReadLine();
            }
        }
    }
}