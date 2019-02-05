namespace P07.SpeedRacing
{
    class Car
    {
        private string model;

        private int fuelAmount;

        private double fuelConsumptionPerKm;

        private double traveledDistance;

        public Car(string model, int fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }


        public string Model { get; set; }

        public int FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TraveledDistance { get; set; }
    }
}