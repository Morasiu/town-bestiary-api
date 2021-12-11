using TownBestiaryApi.Models.Events;
using TownBestiaryApi.Models.Facts;

namespace TownBestiaryApi.Models.Home; 

public class HomeInfo {
	public Fact Fact { get; set; }
	public ICollection<Event> Events { get; set; }
}