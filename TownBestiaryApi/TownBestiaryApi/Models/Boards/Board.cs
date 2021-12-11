namespace TownBestiaryApi.Models.Boards; 

public class Board {
	public int Id { get; set; }
	public int AnimalId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Localization { get; set; }
}