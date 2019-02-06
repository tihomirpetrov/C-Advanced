namespace P07.SpeedRacing
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
            
            string[] input;

            for (int i = 0; i < numberOfCars; i++)
            {
                input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                Car currentCar = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(currentCar);
            }

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                string model = input[1];
                double traveledDistance = double.Parse(input[2]);

                Car currentCar = cars.FirstOrDefault(x => x.Model == model);
                currentCar.CalculateTravelDistance(traveledDistance);

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}