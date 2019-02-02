namespace P11.PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            HashSet<string> addFilter = new HashSet<string>();
            HashSet<string> removeFilter = new HashSet<string>();

            string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Print")
            {
                string filterTypeAndParameter = command[1] + " " + command[2];

                switch (command[0])
                {
                    case "Add filter":
                        addFilter.Add(filterTypeAndParameter);
                        break;
                    case "Remove filter":
                        removeFilter.Add(filterTypeAndParameter);
                        break;
                }

                foreach (var item in removeFilter)
                {
                    addFilter.Remove(item);
                }

                command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var filter in addFilter)
            {
                string[] filterTypeAndParameter = filter.Split(" ");

                string typeFilter;
                string parameter = filterTypeAndParameter[1];


                if (filterTypeAndParameter.Length == 3)
                {
                    typeFilter = filterTypeAndParameter[0] + " " + filterTypeAndParameter[1];
                    parameter = filterTypeAndParameter[2];
                }
                else
                {
                    typeFilter = filterTypeAndParameter[0];
                    parameter = filterTypeAndParameter[1];
                }

                switch (typeFilter)
                {
                    case "Starts with":
                        names.RemoveAll(x => x.StartsWith(parameter));
                        break;
                    case "Ends with":
                        names.RemoveAll(x => x.EndsWith(parameter));
                        break;
                    case "Contains":
                        names.RemoveAll(x => x.Contains(parameter));
                        break;
                    case "Length":
                        names.RemoveAll(x => x.Length == int.Parse(parameter));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}