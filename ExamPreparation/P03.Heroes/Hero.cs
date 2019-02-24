namespace Heroes
{
    using System.Collections.Generic;
    using System.Text;

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

        public override string ToString()
        {
            StringBuilder sbHero = new StringBuilder();
            sbHero.AppendLine($"Hero: {Name} – {Level}lvl");
            sbHero.AppendLine(" Item:");
            sbHero.AppendLine($"  * Strength: {strengthValue}");
            sbHero.AppendLine($"  * Ability: {abilityValue}");
            sbHero.AppendLine($"  * Intelligence: {intelligenceValue}");

            return base.ToString();
        }

    }
}