namespace TownBestiaryApi.Models.Animals; 

public class Species {
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Feeding { get; set; }
	public string Environment { get; set; }
	public Population Population { get; set; }
	public string Photo { get; set; }
}