namespace P11.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int numberOfBadges, int collectionOfPokemon)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadges;
            this.CollectionOfPokemon = collectionOfPokemon;
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public int CollectionOfPokemon { get; set; }
    }
}
