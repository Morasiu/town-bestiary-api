using TownBestiaryApi.Generators;

namespace TownBestiaryApi.Models.Boards;

public class BoardsStorage {
	public static List<Board> Boards { get; } = new() {
		new Board {
			Id = 1, 
			Name = "Domek Jeża Stefana", 
			Description = "Tu mieszka jeż Stefan. Nie przeszkdzaj mu jak śpi :)",
			Localization = "ul. Liściasta 10", 
			Longitude = 50.022744m,
			Latitude = 19.912249m,
			AnimalId = SpeciesGenerator.Species.Skip(6 - 1).First().Id 
		},
		new Board {
			Id = 2, 
			Name = "Chatka Maurycego", 
			Description = "Mała chatka, w której mieszka jeż Maurycy. Przy rondzie Matecznym",
			Localization = "Aleja Spokoju 23",
			Longitude = 50.0654m,
			Latitude = 19.9690m,
			AnimalId = SpeciesGenerator.Species.Skip(6 - 1).First().Id 
		},
		new Board {
			Id = 3, 
			Name = "Kaczka Lusia", 
			Description = "Specjalne miejsce dla sikorki Lusi. Sikorka od 2019 mieszka tutaj.",
			Localization = "Ziemna 2",
			Longitude = 50.0654m,
			Latitude = 19.9690m,
			AnimalId = SpeciesGenerator.Species.Skip(2).First().Id 
		},
		new Board {
			Id = 4, 
			Name = "Sowa huhu", 
			Description = "Wysoko w konarach tego drzewa mieszka mądra sowa Krysia. ",
			Localization = "Nocna 15",
			Longitude = 50.0694m,
			Latitude = 19.9419m,
			AnimalId = SpeciesGenerator.Species.Skip(7 - 1).First().Id 
		},
		new Board {
			Id = 5, 
			Name = "Jeżyk Kasia", 
			Description = "Młody jeżyk Kasia od niedawna dopiero mieszka w tym.",
			Localization = "Jajeczna 24",
			Longitude = 50.0659m,
			Latitude = 19.9321m,
			AnimalId = SpeciesGenerator.Species.Skip(6 - 1).First().Id 
		},
		new Board {
			Id = 6, 
			Name = "Bóbr Bartek", 
			Description = "Bartek wraz z rodziną mieszka w okolicy i buduje tutaj małą tamę.",
			Localization = "Wrzosowa 2",
			Longitude = 50.0404m,
			Latitude = 19.8797m,
			AnimalId = SpeciesGenerator.Species.Skip(5 - 1).First().Id 
		},
		new Board {
			Id = 7, 
			Name = "Wiewiórka Zosia", 
			Description = "Ta skoczna wiwiórka jest znana ze swoich wybryków. Uważaj, bo lubi gubić orzeszki",
			Localization = "Orzechowa 21",
			Longitude = 50.0415m,
			Latitude = 19.9496m,
			AnimalId = SpeciesGenerator.Species.Skip(2 - 1).First().Id 
		},
		new Board {
			Id = 8, 
			Name = "Rodzina kun - ABB ", 
			Description = "W tej małej norce mieści cała rodzina kun.",
			Localization = "Skoczna 65",
			Longitude = 50.0415m,
			Latitude = 19.9496m,
			AnimalId = SpeciesGenerator.Species.Skip(3 - 1).First().Id 
		}
	};
}