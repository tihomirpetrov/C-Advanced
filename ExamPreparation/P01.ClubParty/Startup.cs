namespace P01.ClubParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int maximumCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<int, int>> hallReservationsPeople = new Dictionary<string, Dictionary<int, int>>();

            //List<string> halls = new List<string>();
            //List<int> people = new List<int>();
            Stack<string> tokens = new Stack<string>(input);

            while (maximumCapacity > 0 || tokens.Count > 0)
            {
                string hall = tokens.Pop();
                int reservation = int.Parse(tokens.Pop());
                int peopleIn = int.Parse(tokens.Pop());


                if (peopleIn + reservation <= maximumCapacity)
                {
                    if (!hallReservationsPeople.ContainsKey(hall))
                    {
                        hallReservationsPeople.Add(hall, new Dictionary<int, int>());
                    }
                    if (!hallReservationsPeople[hall].ContainsKey(reservation))
                    {
                        hallReservationsPeople[hall].Add(reservation, 0);
                    }
                    hallReservationsPeople[hall][reservation] = peopleIn;

                    maximumCapacity -= reservation + peopleIn;
                }
                else
                {

                    if (!hallReservationsPeople.ContainsKey(hall))
                    {
                        hallReservationsPeople.Add(hall, new Dictionary<int, int>());
                        if (!hallReservationsPeople[hall].ContainsKey(reservation))
                        {
                            hallReservationsPeople[hall][reservation] = peopleIn;

                        }

                        if (hallReservationsPeople[hall][reservation] > maximumCapacity - reservation)
                        {
                            hallReservationsPeople[hall][reservation] = peopleIn;
                        }
                        else
                        {
                            hallReservationsPeople.Add(hall, new Dictionary<int, int>());
                        }
                    }
                    if (!hallReservationsPeople[hall].ContainsKey(reservation))
                    {
                        hallReservationsPeople[hall].Add(reservation, 0);
                    }
                    hallReservationsPeople[hall][reservation] = peopleIn;
                                       
                    maximumCapacity -= reservation + peopleIn;
                }

            }

            Console.WriteLine();

        }
    }
}