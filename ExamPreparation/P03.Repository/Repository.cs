namespace Repository
{
    using System.Collections.Generic;
    public class Repository
    {
        private Dictionary<int, Person> data;

        private int id = 0;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
        }

        public int Count { get; set; } = 0;

        public void Add(Person person)
        {
            data[id++] = person;
            this.Count++;
        }

        public Person Get(int id)
        {
            Person person = data[id];
            return person;
        }

        public bool Update(int id, Person newPerson)
        {
            if (data.ContainsKey(id))
            {
                data[id] = newPerson;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                this.Count--;
                return true;
            }
            return false;
        }        
    }
}