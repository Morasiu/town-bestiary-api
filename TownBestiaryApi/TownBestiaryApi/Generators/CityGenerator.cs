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
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 2,
				Name = "Warszawa",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 3,
				Name = "Gdańsk",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 4,
				Name = "Katowice",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 5,
				Name = "Kielce",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 6,
				Name = "Bydgoszcz",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 7,
				Name = "Łódź",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 8,
				Name = "Poznań",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 9,
				Name = "Wrocław",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 10,
				Name = "Lublin",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 11,
				Name = "Białystok",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 12,
				Name = "Gdynia",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 13,
				Name = "Opole",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			},
			new City {
				Id = 14,
				Name = "Szczecin",
				Animnals = AnimalGenerator.Animals,
				Boards = BoardsStorage.Boards
			}
		};
	}
}