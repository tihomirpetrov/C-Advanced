namespace Heroes
{
    using System.Collections.Generic;
    using System.Text;

    public class Hero
    {
        //private Dictionary<string, Dictionary<int, Item>> item;

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }

        public override string ToString()
        {
            StringBuilder sbHero = new StringBuilder();
            sbHero.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            sbHero.Append($"{this.Item.ToString()}");         

            return base.ToString();
        }
    }
}