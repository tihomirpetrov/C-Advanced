namespace P01.ClubParty
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            Stack<string> input = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Queue<string> halls = new Queue<string>();
            Queue<int> people = new Queue<int>();
            int allPeople = 0;
            List<int> peopleList = new List<int>();

            while (input.Count > 0)
            {
                string currentPeople = input.Pop();
                int result;
                bool isNumber = int.TryParse(currentPeople, out result);

                if (isNumber && halls.Count > 0)
                {
                    people.Enqueue(result);
                }
                else if (!isNumber)
                {
                    halls.Enqueue(currentPeople);
                }
            }
            
            while (halls.Count > 0 && people.Count > 0)
            {
                int currentPeople = people.Peek();
                if (currentPeople > maxCapacity)
                {
                    break;
                }
                if (allPeople + currentPeople < maxCapacity)
                {
                    peopleList.Add(currentPeople);
                    allPeople += people.Dequeue();
                }
                else if (allPeople + currentPeople == maxCapacity)
                {
                    peopleList.Add(currentPeople);
                    allPeople += people.Dequeue();
                    Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", peopleList)}");
                    allPeople = 0;
                    peopleList.Clear();
                }
                else if (allPeople + currentPeople > maxCapacity && halls.Count > 1)
                {
                    Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", peopleList)}");
                    allPeople = 0;
                    peopleList.Clear();
                    return;
                }
                else
                {
                    break;
                }
            }

            if (halls.Count == 0 && peopleList.Count > 0)
            {
                Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", peopleList)}");
            }
        }
    }
}