using TownBestiaryApi.Models.Animals;
using TownBestiaryApi.Models.Boards;
using TownBestiaryApi.Models.Events;
using TownBestiaryApi.Models.Facts;

namespace TownBestiaryApi.Models {
    public class City {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Species> Species { get; set; }
        public ICollection<Board> Boards { get; set; }
        public ICollection<Event> Events { get; set; }
        public Fact Fact { get; set; }
    }
}