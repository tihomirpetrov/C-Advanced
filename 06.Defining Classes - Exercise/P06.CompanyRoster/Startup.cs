namespace P06.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];               

                if (input.Length == 4)
                {
                    Employee currentEmployee = new Employee(name, salary, position, department);
                    employees.Add(currentEmployee);
                }

                if (input.Length == 6)
                {
                    string email = input[4];
                    int age = int.Parse(input[5]);

                    Employee currentEmployee = new Employee(name, salary, position, department, email, age);
                    employees.Add(currentEmployee);
                }

                if (input.Length == 5)
                {
                    int num;
                    bool isNumeric = int.TryParse(input[4], out num);

                    if (isNumeric)
                    {
                        int age = int.Parse(input[4]);

                        Employee currentEmployee = new Employee(name, salary, position, department, age);
                        employees.Add(currentEmployee);
                    }
                    else
                    {
                        string email = input[4];
                        Employee currentEmployee = new Employee(name, salary, position, department, email);
                        employees.Add(currentEmployee);
                    }
                }
            }

            string highestSalaryDepartment = employees.GroupBy(x => x.Department).OrderByDescending(x => x.Average(s => s.Salary)).FirstOrDefault().Key;

            Console.WriteLine($"Highest Average Salary: {highestSalaryDepartment}");

            foreach (Employee employee in employees.Where(x => x.Department == highestSalaryDepartment).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}