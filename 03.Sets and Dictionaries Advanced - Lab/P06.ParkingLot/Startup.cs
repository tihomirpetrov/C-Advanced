namespace P06.ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            HashSet<string> carNumbers = new HashSet<string>();

            while (input[0] != "END")
            {
                string direction = input[0];
                string carNumber = input[1];
                if (direction == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}