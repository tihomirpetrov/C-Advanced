namespace Heroes
{
    using System;
    using System.Text;

    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }
        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Item:");
            sb.AppendLine($"  * Strength: {strengthValue}");
            sb.AppendLine($"  * Ability: {abilityValue}");
            sb.AppendLine($"  * Intelligence: {intelligenceValue}");

            return sb.ToString();
        }
    }
}