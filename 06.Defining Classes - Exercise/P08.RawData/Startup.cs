namespace P08.RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];
                for (int j = 0; j < 4; j++)
                {
                    double tirePressure = double.Parse(input[j * 2 + 5]);
                    int tireAge = int.Parse(input[j * 2 + 6]);
                    Tire tire = new Tire(tirePressure, tireAge);
                    tires[j] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    foreach (Car car in cars.Where(x => x.Cargo.CargoType == command).Where(x => x.Tires.Any(y => y.TirePressure < 1)))
                    {
                        Console.WriteLine(car.ToString());
                    }
                    break;

                case "flamable":
                    foreach (Car car in cars.Where(x => x.Cargo.CargoType == command).Where(x => x.Engine.EnginePower > 250))
                    {
                        Console.WriteLine(car.ToString());
                    }
                    break;
            }
        }
    }
}