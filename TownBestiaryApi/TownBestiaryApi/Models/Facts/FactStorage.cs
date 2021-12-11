namespace TownBestiaryApi.Models.Facts;

public class FactStorage {
	public static List<Fact> Facts { get; } = new() {
		new Fact() {Id = Guid.NewGuid(), Content = "Najstarszy, potwierdzony wiek kaczki krzyżówki wynosi 29 lat."},
		new Fact() {Id = Guid.NewGuid(), Content = "Bórb europejski może przebywać pod wodą bez przerwy nawet do 15 minut."},
		new Fact() {Id = Guid.NewGuid(), Content = "Kaczki domowe pochodzą od kaczki krzyżówki."},
		new Fact() {Id = Guid.NewGuid(), Content = "Przednie zęby wiewiórek nigdy nie przestają rosnąć."},
		
	};

	public static Fact CityFact { get; set; } = new() {
		Id = Guid.NewGuid(),
		Content = "Ruczaj jest jedną z kilku dzielnic Krakowa, w której można spotkać dziki. Użważak"
	};
}