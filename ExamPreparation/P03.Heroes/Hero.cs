namespace Heroes
{
    using System.Collections.Generic;
    public class Hero
    {
        private Dictionary<int, Item> item;

        public Hero(string name, int level, Item Item)
        {
            this.Name = name;
            this.Level = level;
            this.item = new Dictionary<int, Item>();
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }
    }
}