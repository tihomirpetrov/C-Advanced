namespace DefiningClasses
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            Person firstPerson = new Person("Pesho", 20);
            
            Person secondPerson = new Person("Gosho", 18);
            
            Person thirdPerson = new Person("Stamat", 43);

            Console.WriteLine($"{firstPerson.Name} {firstPerson.Age}");
            Console.WriteLine($"{secondPerson.Name} {secondPerson.Age}");
            Console.WriteLine($"{thirdPerson.Name} {thirdPerson.Age}");                       
        }
    }
}