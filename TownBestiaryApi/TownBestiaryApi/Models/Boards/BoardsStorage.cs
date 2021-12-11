using TownBestiaryApi.MoqData;

namespace TownBestiaryApi.Models.Boards;

public class BoardsStorage {
	public List<Board> Boards { get; } = new() {
		new Board {
			Id = 1, 
			Name = "Domek Jeża Stefana", 
			Description = "Tu mieszka jeż Stefan. Nie przeszkdzaj mu jak śpi :)",
			Localization = "ul. Liściasta 10", 
			AnimalId = AnimalGenerator.Animals.First().Id 
		},
		new Board {
			Id = 2, 
			Name = "Chatka Maurycego", 
			Description = "Mała chatka, w której mieszka jeż Maurycy. Przy rondzie Matecznym",
			Localization = "Aleja Spokoju 23", 
			AnimalId = AnimalGenerator.Animals.Skip(1).First().Id 
		},
		new Board {
			Id = 3, 
			Name = "Sikorka Lusia", 
			Description = "Gnizdko sikorki Lusi. Sikorka od 2019 mieszka tutaj.",
			Localization = "Ziemna 2", 
			AnimalId = AnimalGenerator.Animals.Skip(2).First().Id 
		}
	};
}