namespace SoftUniParking
{
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private Dictionary<string, Car> cars;
        private readonly int capacity;

        public Parking(int capacity)
        {
            this.cars = new Dictionary<string, Car>();
            this.capacity = capacity;
        }

        public int Count => this.cars.Count;

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            else if (this.cars.Count == this.capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car.RegistrationNumber, car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                this.cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return this.cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registationNumbers)
        {
            foreach (var registationNumber in registationNumbers)
            {
                this.RemoveCar(registationNumber);
            }
        }
    }
}