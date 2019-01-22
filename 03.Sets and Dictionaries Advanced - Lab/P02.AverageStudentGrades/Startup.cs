namespace P02.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double>());
                }
                grades[name].Add(grade);
            }

            foreach (var student in grades)
            {
                foreach (var grade in student.Value)
                {
                    Console.Write(string.Join(" ", student.Key));
                    Console.WriteLine(string.Join(" ", $" -> {grade} ({student.Value.Average():f2})"));
                }
            }
        }
    }
}