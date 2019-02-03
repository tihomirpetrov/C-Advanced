using System;
using System.Text;

namespace CarManufacturer

{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

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

        public void Drive(double distance)
        {
            var consumedFuel = distance * (this.fuelConsumption / 100);

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
}
