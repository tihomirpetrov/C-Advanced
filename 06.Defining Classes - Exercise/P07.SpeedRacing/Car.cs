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
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.traveledDistance = 0.0;
        }

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerKm
        {
            get { return this.fuelConsumptionPerKm; }
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public void CalculateTravelDistance(double kilometers)
        {
            double neededFuel = kilometers * this.fuelConsumptionPerKm;

            if (this.fuelAmount < neededFuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= neededFuel;
            this.traveledDistance += kilometers;            
        }
    }
}