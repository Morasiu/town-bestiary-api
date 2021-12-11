using TownBestiaryApi.Extensions;
using TownBestiaryApi.Models;
using TownBestiaryApi.Models.Boards;
using TownBestiaryApi.Models.Events;
using TownBestiaryApi.Models.Facts;

namespace TownBestiaryApi.Generators;

public static class CityGenerator {
	public static List<City> Cities { get; set; }

	static CityGenerator() {
		Cities = new List<City> {
			new City {
				Id = 1,
				Name = "Kraków",
			},
			new City {
				Id = 2,
				Name = "Warszawa",
			},
			new City {
				Id = 3,
				Name = "Gdańsk",
			},
			new City {
				Id = 4,
				Name = "Katowice",
			},
			new City {
				Id = 5,
				Name = "Kielce",
			},
			new City {
				Id = 6,
				Name = "Bydgoszcz",
			},
			new City {
				Id = 7,
				Name = "Łódź",
			},
			new City {
				Id = 8,
				Name = "Poznań",
			},
			new City {
				Id = 9,
				Name = "Wrocław",
			},
			new City {
				Id = 10,
				Name = "Lublin",
			},
			new City {
				Id = 11,
				Name = "Białystok",
			},
			new City {
				Id = 12,
				Name = "Gdynia",
			},
			new City {
				Id = 13,
				Name = "Opole",
			},
			new City {
				Id = 14,
				Name = "Szczecin",
			}
		};

		for (int i = 0; i < Cities.Count; i++) {
			var city = Cities[i];
			city.Species = SpeciesGenerator.Species;
			city.Boards = BoardsStorage.Boards;
			city.Events = EventStorage.CityEvents;
			city.Fact = FactStorage.CityFact;
		}
	}
}