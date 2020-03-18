namespace GamesStore.DAL.Entities
{
    public class Game: Entity
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public Developer Developer { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
