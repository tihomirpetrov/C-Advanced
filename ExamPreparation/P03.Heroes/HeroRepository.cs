namespace Heroes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> data;
        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count => this.data.Count;
        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                int index = -1;
                if (this.data[i].Name.CompareTo(name) == 0)
                {
                    index = i;
                }
                this.data.RemoveAt(i);
            }            
        }

        public Hero GetHeroWithHighestStrength()
        {
            this.data.OrderByDescending(x => x.Item.Strength);
            Hero hero = this.data.FirstOrDefault();
            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            this.data.OrderByDescending(x => x.Item.Ability);
            Hero hero = this.data.FirstOrDefault();
            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            this.data.OrderByDescending(x => x.Item.Intelligence);
            Hero hero = this.data.FirstOrDefault();
            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb2 = new StringBuilder();
            foreach (Hero item in this.data)
            {
                sb2.Append(item.ToString());
            }
            return sb2.ToString();            
        }
    }
}