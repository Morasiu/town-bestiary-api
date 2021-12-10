using TownBestiaryApi.Models.Animals;

namespace TownBestiaryApi.Models {
    public class City {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Animal> Animnals { get; set; }
        public ICollection<Board> Boards { get; set; }
    }
}