namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class StartUp
    {
        public class Car
        {
            private string make;

            private string model;

            private int year;

            private double fuelQuantity;

            private double fuelConsumption;

            private Engine engine;

            private Tire[] tires;

            public string Make
            {
                get { return this.make; }
                set { this.make = value; }
            }

            public string Model
            {
                get { return this.model; }
                set { this.model = value; }
            }

            public int Year
            {
                get { return this.year; }
                set { this.year = value; }
            }

            public double FuelQuantity
            {
                get { return this.fuelQuantity; }
                set { this.fuelQuantity = value; }
            }

            public double FuelConsumption
            {
                get { return this.fuelConsumption; }
                set { this.fuelConsumption = value; }
            }

            public Engine Engine { get; set; }

            public Tire[] Tires { get; set; }

            public Car()
            {
                this.Make = "VW";
                this.Model = "Golf";
                this.Year = 2025;
                this.FuelQuantity = 200;
                this.FuelConsumption = 10;
            }

            public Car(string make, string model, int year)
                : this()
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
                : this(make, model, year)
            {
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumption = fuelConsumption;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
                : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                this.Engine = engine;
                this.Tires = tires;
            }

            public void Drive(double distance)
            {
                double consumedFuel = distance * (this.fuelConsumption / 100);

                if (this.fuelQuantity - consumedFuel < 0)
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                }
                else
                {
                    this.fuelQuantity -= consumedFuel;
                }
            }

            public string WhoAmI()
            {
                StringBuilder carInfo = new StringBuilder();

                carInfo.AppendLine($"Make: {this.Make}");

                carInfo.AppendLine($"Model: {this.Model}");

                carInfo.AppendLine($"Year: {this.Year}");

                carInfo.Append($"Fuel: {this.FuelQuantity:F2}L");

                return carInfo.ToString();
            }
        }

        public class Engine
        {
            private int horsePower;

            private double cubicCapacity;

            public int HorsePower { get; set; }

            public double CubicCapacity { get; set; }

            public Engine(int horsePower, double cubicCapacity)
            {
                this.HorsePower = horsePower;
                this.CubicCapacity = cubicCapacity;
            }
        }

        public class Tire
        {
            private int year;

            private double pressure;

            public int Year { get; set; }
            public double Pressure { get; set; }

            public Tire(int year, double pressure)
            {
                this.Year = year;
                this.Pressure = pressure;
            }
        }

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

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);

                input = Console.ReadLine();
            }

            List<Car> filteredCars = cars.FindAll(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Select(y => y.Pressure).Sum() > 9 && x.Tires.Select(y => y.Pressure).Sum() < 10).ToList();

            for (int i = 0; i < filteredCars.Count; i++)
            {
                filteredCars[i].Drive(20);
            }

            foreach (var specialCar in filteredCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}