namespace DefiningClasses
{
    using System;

    public class Person
    {
        private string name;

        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Invalid name");
            }

            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}