using System;

namespace P07.SpeedRacing
{
    public class Car
    {
        private string model;

        private double fuelAmount;

        private double fuelConsumptionPerKm;

        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double CalculateTravelDistance(string model, double fuelConsumptionPerKm)
        {
            if (traveledDistance > fuelAmount / fuelConsumptionPerKm)
            {
                fuelAmount -= (fuelAmount / fuelConsumptionPerKm) - traveledDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            return FuelAmount;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TraveledDistance { get; set; }
    }
}