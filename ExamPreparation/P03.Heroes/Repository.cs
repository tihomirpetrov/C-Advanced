namespace Heroes
{
    using System.Collections.Generic;
    using System.Linq;
    public class Repository
    {
        private Dictionary<int, Hero> data;
        private int id = 0;
        public Repository()
        {
            this.data = new Dictionary<int, Hero>();
        }

        public int Count { get; set; } = 0;
        public void Add(Hero hero)
        {
            data[id++] = hero;
        }

        public bool Remove(string name)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                return true;
            }
            return false;
        }

        public Hero GetHeroWithHighestStrength(Hero hero, Item item)
        {
            Hero maxStrength = item.Strength(x => x.Strength);

            if (hero.Item.Equals(currentHero))
            {

            }
            return hero;
        }

        public Hero GetHeroWithHighestAbility(Hero hero)
        {

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence(Hero hero)
        {

            return hero;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}