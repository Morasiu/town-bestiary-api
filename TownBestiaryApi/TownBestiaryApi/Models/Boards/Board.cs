namespace TownBestiaryApi.Models.Boards; 

public class Board {
	public int Id { get; set; }
	public int SpeciesId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Localization { get; set; }
	public decimal Longitude { get; set; }
	public decimal Latitude { get; set; }
}