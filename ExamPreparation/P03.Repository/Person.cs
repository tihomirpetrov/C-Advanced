namespace Repository
{
    using System;
     public class Person
    {
        private string name;
        private int age;
        private DateTime birthdate;

        public Person(string name, int age, DateTime birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
    }
}