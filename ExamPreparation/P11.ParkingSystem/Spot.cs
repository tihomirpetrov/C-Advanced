namespace P11.ParkingSystem
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }


        public string Name { get; set; }

        public int Age { get; set; }

        public string HomeCity { get; set; }
    }
}