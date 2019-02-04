namespace DefiningClasses
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            Person firstPerson = new Person();
            {
                firstPerson.Name = "Pesho";
                firstPerson.Age = 20;
            };

            Person secondPerson = new Person();
            {
                secondPerson.Name = "Gosho";
                secondPerson.Age = 18;
            }

            Person thirdPerson = new Person();
            {
                thirdPerson.Name = "Stamat";
                thirdPerson.Age = 43;
            }
        }
    }
}