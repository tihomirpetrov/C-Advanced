namespace P01.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] patientsInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<int, List<string>>> departmentRoomPatient = new Dictionary<string, Dictionary<int, List<string>>>();
            Dictionary<string, List<string>> doctorPatients = new Dictionary<string, List<string>>();

            while (patientsInformation[0] != "Output")
            {
                string department = patientsInformation[0];
                string doctor = patientsInformation[1] + " " + patientsInformation[2];
                string patient = patientsInformation[3];

                if (!departmentRoomPatient.ContainsKey(department))
                {
                    departmentRoomPatient[department] = new Dictionary<int, List<string>>();
                    for (int rooms = 1; rooms <= 20; rooms++)
                    {
                        departmentRoomPatient[department].Add(rooms, new List<string>());
                    }
                }

                for (int i = 1; i <= 20; i++)
                {
                    if (departmentRoomPatient[department][i].Count < 3)
                    {
                        departmentRoomPatient[department][i].Add(patient);
                        if (!doctorPatients.ContainsKey(doctor))
                        {
                            doctorPatients.Add(doctor, new List<string>());
                        }
                        doctorPatients[doctor].Add(patient);
                        break;
                    }
                }

                patientsInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string[] input2 = Console.ReadLine().Split().ToArray();

            while (input2[0] != "End")
            {
                if (input2.Length == 1)
                {
                    string department = input2[0];

                    foreach (var rooms in departmentRoomPatient[department])
                    {
                        foreach (var patient in rooms.Value)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }

                else
                {
                    string department = input2[0];

                    if (departmentRoomPatient.ContainsKey(department))
                    {
                        int room = int.Parse(input2[1]);
                        foreach (var patient in departmentRoomPatient[department][room].OrderBy(x => x))
                        {
                            Console.WriteLine(patient);
                        }
                    }

                    else
                    {
                        string doctor = input2[0] + " " + input2[1];

                        foreach (var patients in doctorPatients[doctor].OrderBy(x => x))
                        {
                            Console.WriteLine(patients);
                        }
                    }
                }

                input2 = Console.ReadLine().Split().ToArray();
            }
        }
    }
}