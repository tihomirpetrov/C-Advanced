namespace P10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine;
                if (input.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                else if (input.Length == 3)
                {
                    int displacement;
                    bool isNumber = int.TryParse(input[2], out displacement);

                    if (isNumber)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, input[2]);
                    }
                }

                else
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }

                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);
                Car car;

                if (input.Length == 2)
                {
                    car = new Car(model, engine);
                }

                else if (input.Length == 3)
                {
                    int weight;
                    bool isNumber = int.TryParse(input[2], out weight);

                    if (isNumber)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, input[2]);
                    }
                }

                else
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];

                    car = new Car(model, engine, weight, color);
                }

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}