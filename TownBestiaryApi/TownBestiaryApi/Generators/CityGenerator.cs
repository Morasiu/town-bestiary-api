using TownBestiaryApi.Models;
using TownBestiaryApi.Models.Boards;

namespace TownBestiaryApi.Generators;

public static class CityGenerator {
	public static List<City> Cities { get; set; }

	static CityGenerator() {
		Cities = new List<City> {
			new City {
				Id = 1,
				Name = "Kraków",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 2,
				Name = "Warszawa",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 3,
				Name = "Gdańsk",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 4,
				Name = "Katowice",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 5,
				Name = "Kielce",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 6,
				Name = "Bydgoszcz",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 7,
				Name = "Łódź",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 8,
				Name = "Poznań",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 9,
				Name = "Wrocław",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 10,
				Name = "Lublin",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 11,
				Name = "Białystok",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 12,
				Name = "Gdynia",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 13,
				Name = "Opole",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 14,
				Name = "Szczecin",
				Species = SpeciesGenerator.Species,
				Boards = BoardsStorage.Boards
			}
		};
	}
}